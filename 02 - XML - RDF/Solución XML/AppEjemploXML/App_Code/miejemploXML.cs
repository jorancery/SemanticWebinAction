﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Este código fuente fue generado automáticamente por xsd, Versión=4.6.1055.0.
// 
namespace ns_miejemplo {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class lista {
        
        private listaContacto[] contactoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contacto")]
        public listaContacto[] contacto {
            get {
                return this.contactoField;
            }
            set {
                this.contactoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class listaContacto {
        
        private string nombreField;
        
        private string apellidosField;
        
        private System.DateTime fecha_nacimientoField;
        
        private bool fecha_nacimientoFieldSpecified;
        
        private listaContactoCorreos[] correosField;
        
        private string descripciónField;
        
        /// <remarks/>
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string apellidos {
            get {
                return this.apellidosField;
            }
            set {
                this.apellidosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime fecha_nacimiento {
            get {
                return this.fecha_nacimientoField;
            }
            set {
                this.fecha_nacimientoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fecha_nacimientoSpecified {
            get {
                return this.fecha_nacimientoFieldSpecified;
            }
            set {
                this.fecha_nacimientoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("correos")]
        public listaContactoCorreos[] correos {
            get {
                return this.correosField;
            }
            set {
                this.correosField = value;
            }
        }
        
        /// <remarks/>
        public string descripción {
            get {
                return this.descripciónField;
            }
            set {
                this.descripciónField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class listaContactoCorreos {
        
        private byte idcorreoField;
        
        private string descripcion_correoField;
        
        /// <remarks/>
        public byte idcorreo {
            get {
                return this.idcorreoField;
            }
            set {
                this.idcorreoField = value;
            }
        }
        
        /// <remarks/>
        public string descripcion_correo {
            get {
                return this.descripcion_correoField;
            }
            set {
                this.descripcion_correoField = value;
            }
        }
    }
}
