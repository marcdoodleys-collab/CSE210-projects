// Customer.cs
public class Customer
{
    // Variables privées
    private string _name;
    private Address _address;

    // Constructeur
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getters
    public string GetName() { return _name; }
    public Address GetAddress() { return _address; }

    // Cette méthode appelle IsInUSA() sur l'objet Address (comme suggéré dans la consigne)
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}