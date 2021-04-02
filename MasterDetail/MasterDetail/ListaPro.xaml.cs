using MasterDetail.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPro : ContentPage
    {
        public IList<Productos> productos{ get; private set; }

        public ListaPro()
        {
            InitializeComponent();
            productos = new List<Productos>();

            productos.Add(new Productos { Id="1 " , Nombre = "Arroz", Descripcion="Fino",  Precio="50 Bs",
                
                URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/White%2C_Brown%2C_Red_%26_Wild_rice.jpg/280px-White%2C_Brown%2C_Red_%26_Wild_rice.jpg", Cantidad="80 qq" ,Codigo = "║│║║│║│" });
            productos.Add(new Productos{  Id="2",Nombre = "Fideo", Descripcion="Famosa",Precio="45 Bs",
                URL = "http://famosa.com.bo/web/wp-content/uploads/2015/05/27.jpg", Cantidad ="40 qq", Codigo = "║║│║║║│" });
            productos.Add(new Productos { Id="3",Nombre = "Sardina", Descripcion="Omega",Precio ="12 Bs", 
                URL = "https://redsuperbo.com/cart/image/cache/catalog/productos/enlatados/san%20lucas%20tall-500x500.png", Cantidad ="30 Cajas", Codigo= "║║│║│║│" });
            productos.Add(new Productos { Id = "4", Nombre = "Aceite", Descripcion = "Sao", Precio = "55 Bs", 
                URL = "http://famosa.com.bo/web/wp-content/uploads/2015/05/27.jpg", Cantidad = "46 Cajas", Codigo = "║│║║│║│" });
            productos.Add(new Productos { Id = "5", Nombre = "Harina", Descripcion = "Viada", Precio = "200 Bs",
                URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/White%2C_Brown%2C_Red_%26_Wild_rice.jpg/280px-White%2C_Brown%2C_Red_%26_Wild_rice.jpg", Cantidad = "65 qq", Codigo = "║║│║║││" });
            productos.Add(new Productos { Id = "6", Nombre = "Azucar", Descripcion = "Unagro", Precio = "150 Bs",
                URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/White%2C_Brown%2C_Red_%26_Wild_rice.jpg/280px-White%2C_Brown%2C_Red_%26_Wild_rice.jpg", Cantidad = "34 qq", Codigo = "║║│║║│║" });

            BindingContext = this;

        }

       private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Productos selectedItem = e.SelectedItem as Productos;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Productos tappedSelected = e.Item as Productos;
        }
    }
}
    
