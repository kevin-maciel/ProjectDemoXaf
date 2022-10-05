using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ProjectDemoXaf.Module.BusinessObjects
{
    [NavigationItem("Cajas del CD")]
    public class Cajas : BaseObject
    {
        public Cajas(Session session) : base(session) { }
        int id;
        public int Id
        {
            get { return id; }
            set { SetPropertyValue(nameof(Id), ref id, value); }
        }
        string caja;
        public string Caja
        {
            get { return caja; }
            set { SetPropertyValue(nameof(Caja), ref caja, value); }
        }
        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { SetPropertyValue(nameof(Descripcion), ref descripcion, value); }
        }
        DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { SetPropertyValue(nameof(Fecha), ref fecha, value); }
        }

    }
}
