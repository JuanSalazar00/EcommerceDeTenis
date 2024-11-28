using System.Collections.ObjectModel;
using EcommerceDeTenis.Models;

namespace EcommerceDeTenis.ViewModels;

public class CarritoViewModel
{
    // Instancia compartida
    public static CarritoViewModel Instancia { get; } = new CarritoViewModel();

    // Lista observable para reflejar cambios automáticamente
    public ObservableCollection<Tenis> Carrito { get; }

    public CarritoViewModel()
    {
        Carrito = new ObservableCollection<Tenis>();
    }

    // Método para agregar elementos al carrito
    public void AgregarAlCarrito(Tenis tenis)
    {
        if (tenis != null && !Carrito.Contains(tenis)) // Evitar duplicados
        {
            Carrito.Add(tenis);
            System.Diagnostics.Debug.WriteLine($"Agregado al carrito: {tenis.Nombre}");
        }
    }
}

