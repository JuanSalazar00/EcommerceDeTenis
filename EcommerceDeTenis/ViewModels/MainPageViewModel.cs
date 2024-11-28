using System.Collections.ObjectModel;
using System.Windows.Input;
using EcommerceDeTenis.Models;

namespace EcommerceDeTenis.ViewModels;

public class MainPageViewModel
{
    public ObservableCollection<Tenis> ListaDeTenis { get; set; }
    public ICommand AgregarAlCarritoCommand { get; }

    public MainPageViewModel()
    {
        // Inicializar la lista de tenis
        ListaDeTenis = new ObservableCollection<Tenis>
        {
            new Tenis { Nombre = "Tenis Nike", Imagen = "tenis_nike.png", Precio = 1200 },
            new Tenis { Nombre = "Adidas Running", Imagen = "tenis_adidas.png", Precio = 1400 },
            new Tenis { Nombre = "Puma Casual", Imagen = "tenis_puma.png", Precio = 1000 }
        };

        // Configurar el comando para agregar al carrito
        AgregarAlCarritoCommand = new Command<Tenis>(tenis =>
        {
            if (tenis != null)
            {
                // Enviar al carrito
                CarritoViewModel.Instancia.AgregarAlCarrito(tenis);
            }
        });
    }
}

