from pyspark.sql import SparkSession

spark = SparkSession.builder.master("local").appName("task_spark").getOrCreate()

categories = spark.createDataFrame(
    [
        (1, "Food"),
        (2, "Drinks"),
        (3, "Laundry detergent"),
        (4, "Soap"),
        (5, "Milk"),
        (6, "Toothpaste"),
        (7, "Smartphones")
    ],
    ["id", "category_name"]
)

products = spark.createDataFrame(
    [
        (1, "a"),
        (2, "b"),
        (3, "c"),
        (4, "d"),
        (5, "e"),
        (6, "f"),
        (7, "g"),
        (8, "h"),
        (9, "i"),
        (10, "j")
    ],
    ["id", "product_name"]
)

match_ = spark.createDataFrame(
    [
        (1, 4),
        (2, 2),
        (3, 1),
        (3, 3),
        (4, 5),
        (4, 6),
        (6, 7),
        (6, 8),
        (5, 8)
    ],
    ["category_id", "product_id"]
)

products.join(match_, products.id == match_.product_id, how="left") \
    .join(categories, match_.category_id == categories.id, how="left") \
    .select(["product_name", "category_name"]) \
    .orderBy(products.id).show()
