// Order.cs
using System.Collections.Generic;
using System.Text;

public class Order
{
    // Variables privées
    private List<Product> _products;
    private Customer _customer;

    // Coûts de livraison fixes selon la consigne
    private const double ShippingCostUSA = 5.0;
    private const double ShippingCostOther = 35.0;

    // Constructeur
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Prix total = somme du coût de chaque produit + coût de livraison
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // On ajoute le coût de livraison selon le pays du client
        if (_customer.LivesInUSA())
        {
            total += ShippingCostUSA;
        }
        else
        {
            total += ShippingCostOther;
        }

        return total;
    }

    // Étiquette d'emballage : nom + id de chaque produit
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        foreach (Product product in _products)
        {
            label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }

        // On enlève le dernier retour à la ligne en trop
        return label.ToString().TrimEnd();
    }

    // Étiquette d'expédition : nom du client + adresse complète
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}