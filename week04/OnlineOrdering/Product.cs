// Product.cs
public class Product
{
    // Variables privées
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructeur
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getters
    public string GetName() { return _name; }
    public string GetProductId() { return _productId; }
    public double GetPrice() { return _price; }
    public int GetQuantity() { return _quantity; }

    // Coût total de ce produit = prix unitaire * quantité
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}