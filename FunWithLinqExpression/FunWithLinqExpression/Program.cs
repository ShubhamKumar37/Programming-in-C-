ProductInfo[] itemsInStock = new[] {
    new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
    new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
    new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
    new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
    new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves  pizza!",  NumberInStock = 73}
};

//var result = from matchingItem in itemsInStock select matchingItem;
//var OnlyNames = from name in itemsInStock select name.Name;
//var MoreThenItems = from i in itemsInStock where i.NumberInStock > 25 select i;
//var OnlySelectedField = from i in itemsInStock where i .NumberInStock > 25 select new {i.Name, i.NumberInStock};

//Print(result);
//Print(OnlyNames);
//Print(MoreThenItems);
//Print(OnlySelectedField);

//foreach (var i in GetProjectedSubste(itemsInStock)) Console.WriteLine(i);


//static Array GetProjectedSubste<ProductInfo>(ProductInfo[] arr)
//{
//    return (from i in arr select i).ToArray();
//}

IEnumerable<ProductInfoSmall> smallInfo = from j in itemsInStock select new ProductInfoSmall { Name = j.Name, Description = j.Description };
int count = (from j in itemsInStock select new ProductInfoSmall { Name = j.Name, Description = j.Description }).Count();
Console.WriteLine("This is the lenght of array {0}", count);
Print(smallInfo);
static void Print<T>(IEnumerable<T> item)
{
    //foreach(var i in item) Console.WriteLine(i.ToString());
    foreach(var i in item.Reverse()) Console.WriteLine(i.ToString()); // We can make it reverse
}
class ProductInfo
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int NumberInStock { get; set; } = 0;
    public override string ToString() => $"Name={Name}, Description={Description}, Number in Stock={NumberInStock}";
}

class ProductInfoSmall
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public override string ToString()
    => $"Name={Name}, Description={Description}";
}