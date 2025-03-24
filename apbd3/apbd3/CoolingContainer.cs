namespace apbd3;

public class CoolingContainer : Container
{
    private static int _coolingCount;
    private Dictionary<string, double> _products;
    public double Temperature;
    public string? Product;

    public CoolingContainer(int height, int weight, int depth, int maximumLoadWeight) : base(height,
        weight, depth, maximumLoadWeight)
    {
        SerialNumber += "C-" + _coolingCount++;
        _products = new Dictionary<string, double>
        {
            { "Bananas", 13.3 },
            { "Chocolate", 18 },
            { "Fish", 2 },
            { "Meat", -15 },
            { "Ice cream", -18 },
            { "Frozen pizza", -30 },
            { "Cheese", 7.2 },
            { "Sausages", 5 },
            { "Butter", 20.5 },
            { "Eggs", 19 }
        };
        Temperature = 25;
    }

    public void LoadContainer(int weight, string product)
    {
        if (Product == null)
        {
            if (_products.TryGetValue(product, out double temp) && Temperature < temp)
            {
                Console.WriteLine("Temperature is too low for this product");
                return;
            }

            Product = product;
            Temperature = _products.GetValueOrDefault(Product, 25);
        }
        else if (!Product.Equals(product))
        {
            Console.WriteLine("Cannot store two different products in one cooling container");
            return;
        }

        base.LoadContainer(weight);
    }

    public override void UnloadContainer()
    {
        Product = null;
        base.UnloadContainer();
    }

    public override string ToString()
    {
        return "Cooling " + base.ToString() + $", {nameof(Product)}: {Product}, {nameof(Temperature)}: {Temperature}";
    }
}