﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="MyData")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="MyData", IsNullable=false)]
public partial class Students {
    
    private StudentsStudent[] studentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Student")]
    public StudentsStudent[] Student {
        get {
            return this.studentField;
        }
        set {
            this.studentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="MyData")]
public partial class StudentsStudent {
    
    private uint indexField;
    
    private string nameField;
    
    private string surnameField;
    
    private System.DateTime birthDateField;
    
    private StudentsStudentAddress[] addressField;
    
    private StudentsStudentSubject[] coursesField;
    
    /// <remarks/>
    public uint Index {
        get {
            return this.indexField;
        }
        set {
            this.indexField = value;
        }
    }
    
    /// <remarks/>
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string Surname {
        get {
            return this.surnameField;
        }
        set {
            this.surnameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime BirthDate {
        get {
            return this.birthDateField;
        }
        set {
            this.birthDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Address")]
    public StudentsStudentAddress[] Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Subject", IsNullable=false)]
    public StudentsStudentSubject[] Courses {
        get {
            return this.coursesField;
        }
        set {
            this.coursesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="MyData")]
public partial class StudentsStudentAddress {
    
    private string cityField;
    
    private string streetField;
    
    private string typeField;
    
    /// <remarks/>
    public string City {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public string Street {
        get {
            return this.streetField;
        }
        set {
            this.streetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="MyData")]
public partial class StudentsStudentSubject {
    
    private string nameField;
    
    private decimal gradeField;
    
    /// <remarks/>
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public decimal Grade {
        get {
            return this.gradeField;
        }
        set {
            this.gradeField = value;
        }
    }
}
