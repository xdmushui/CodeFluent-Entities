﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManager.Services
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Thursday, 13 February 2014 19:31.
    // Build:1.0.61214.0762
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0762")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.contactmanager.com")]
    public partial interface IContactSourceService
    {
        
        [System.ServiceModel.OperationContractAttribute()]
        string Validate(ContactManager.ContactSource contactSource, string culture);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool Delete(ContactManager.ContactSource contactSource);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.ContactSource Load(int id);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.ContactSource LoadById(int id);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool Save(ContactManager.ContactSource contactSource);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool SaveByRef(ref ContactManager.ContactSource contactSource);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.ContactSource LoadByEntityKey(string key);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool DeleteByKey(int id);
        
        [System.ServiceModel.OperationContractAttribute()]
        void SaveAll(ContactManager.ContactSourceCollection contactSourceCollection);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.ContactSourceCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.ContactSourceCollection LoadAll();
    }
}