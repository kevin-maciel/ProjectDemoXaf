﻿using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProjectDemoXaf.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class MaterialesEmpaque : BaseObject
    { 
        public MaterialesEmpaque(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        DateTime fachaBaja;
        int vencimiento;
        string descripcion;
        int codigo;

        public int Codigo
        {
            get => codigo;
            set => SetPropertyValue(nameof(Codigo), ref codigo, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Descripcion
        {
            get => descripcion;
            set => SetPropertyValue(nameof(Descripcion), ref descripcion, value);
        }


        public int Vencimiento
        {
            get => vencimiento;
            set => SetPropertyValue(nameof(Vencimiento), ref vencimiento, value);
        }

        
        public DateTime FachaBaja
        {
            get => fachaBaja;
            set => SetPropertyValue(nameof(FachaBaja), ref fachaBaja, value);
        }

    }
}