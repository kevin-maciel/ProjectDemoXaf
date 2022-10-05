using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace ProjectDemoXaf.Module.BusinessObjects
{
    //[NavigationItem("Materiales")]
    public class MateriaPrima : BaseObject
    {
        public MateriaPrima(Session session) : base(session)
        {
        }
        int id;
        public int Id
        {
            get { return id; }
            set { SetPropertyValue(nameof(Id), ref id, value); }
        }
        string materiaPrima;
        public string MateriaPrimas
        {
            get { return materiaPrima; }
            set { SetPropertyValue(nameof(MateriaPrimas), ref materiaPrima, value); }
        }
        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { SetPropertyValue(nameof(Descripcion), ref descripcion, value); }
        }
    }
}
