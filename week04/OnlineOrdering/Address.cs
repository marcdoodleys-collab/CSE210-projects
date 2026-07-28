// Address.cs
using System;

public class Address
{
    // Toutes les variables sont privées (encapsulation)
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructeur : on doit fournir toutes les infos à la création
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Getters (pas besoin de setters ici, car pas demandés explicitement)
    public string GetStreet() { return _street; }
    public string GetCity() { return _city; }
    public string GetState() { return _state; }
    public string GetCountry() { return _country; }

    // Retourne vrai si le pays est USA (on compare en ignorant majuscules/minuscules)
    public bool IsInUSA()
    {
        return _country.Trim().ToLower() == "usa";
    }

    // Retourne l'adresse complète sur plusieurs lignes
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}