﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.ComponentOne
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 06 October 2014 17:27.
    // Build:1.0.61214.0786
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Email={Email}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class User : System.ICloneable, System.IComparable, System.IComparable<SoftFluent.Samples.ComponentOne.User>, CodeFluent.Runtime.ICodeFluentCollectionEntity<string>, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<SoftFluent.Samples.ComponentOne.User>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private byte[] _rowVersion;
        
        private System.Guid _id = CodeFluentPersistence.DefaultGuidValue;
        
        private string _email = default(string);
        
        private string _firstName = default(string);
        
        private string _lastName = default(string);
        
        [System.NonSerializedAttribute()]
        protected CodeFluent.Runtime.BinaryServices.BinaryLargeObject _photo = default(CodeFluent.Runtime.BinaryServices.BinaryLargeObject);
        
        [System.NonSerializedAttribute()]
        private SoftFluent.Samples.ComponentOne.ContactCollection _contacts;
        
        [System.NonSerializedAttribute()]
        private static CodeFluent.Runtime.Rules.EmailValidator _emailValidator0 = new CodeFluent.Runtime.Rules.EmailValidator(SoftFluent.Samples.ComponentOne.Resources.ValueValidationFailureHandler.Current, default(string), null, System.Text.RegularExpressions.RegexOptions.IgnoreCase, default(CodeFluent.Runtime.Rules.StringValidatorOptions));
        
        public User()
        {
            this._id = System.Guid.NewGuid();
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.Id.ToString();
            }
            set
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(value, typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.Email;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [System.ComponentModel.DataObjectFieldAttribute(false, true)]
        [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.ByteArrayConverter))]
        public byte[] RowVersion
        {
            get
            {
                return this._rowVersion;
            }
            set
            {
                if (((value != null) 
                            && (value.Length == 0)))
                {
                    value = null;
                }
                this._rowVersion = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("RowVersion"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.Guid))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public System.Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((value.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
                    this._id = System.Guid.NewGuid();
                }
                else
                {
                    this._id = value;
                }
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
                this.BinaryLargeObjectsReset();
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<string>.Default.Equals(value, this._email) == true))
                {
                    return;
                }
                string oldKey = this._email;
                this._email = value;
                try
                {
                    this.OnCollectionKeyChanged(oldKey);
                }
                catch (System.ArgumentException )
                {
                    this._email = oldKey;
                    return;
                }
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Email"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("FirstName"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("LastName"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.BinaryLargeObjectTypeConverter2))]
        public CodeFluent.Runtime.BinaryServices.BinaryLargeObject Photo
        {
            get
            {
                if ((this._photo == null))
                {
                    this._photo = CodeFluentContext.Get(SoftFluent.Samples.ComponentOne.Constants.SoftFluent_Samples_ComponentOneStoreName).Configuration.BinaryServices.CreateObject(this);
                    this._photo.PersistenceOptions.AddIdentifierColumnName("User_Id");
                    this._photo.PersistenceOptions.AddLoadMetaDataParameterName("Id");
                    this._photo.PersistenceOptions.AddLoadParameterName("User_Id");
                    this._photo.PersistenceOptions.AddSaveParameterName("User_Id");
                    this._photo.PersistenceOptions.DataColumnName = "User_Photo";
                    this._photo.PersistenceOptions.MetaDatasMask = CodeFluent.Runtime.BinaryServices.BinaryLargeObjectMetaDatas.All;
                    this._photo.PersistenceOptions.PackageName = "User";
                    this._photo.PersistenceOptions.Schema = null;
                    this._photo.PersistenceOptions.LoadMetaDataProcedureName = "Load";
                    this._photo.PersistenceOptions.LoadProcedureName = "LoadBlobUser_Photo";
                    this._photo.PersistenceOptions.SaveProcedureName = "SaveBlobUser_Photo";
                    this._photo.PersistenceOptions.SaveChunkProcedureName = "SaveBlobChunkUser_Photo";
                    this._photo.PersistenceOptions.FileNameColumnName = "User_Photo_FileName";
                    this._photo.PersistenceOptions.ContentTypeColumnName = "User_Photo_ContentType";
                    this._photo.PersistenceOptions.AttributesColumnName = "User_Photo_Attributes";
                    this._photo.PersistenceOptions.SizeColumnName = "User_Photo_Size";
                    this._photo.PersistenceOptions.LastWriteTimeUtcColumnName = "User_Photo_LastWriteTimeUtc";
                    this._photo.PersistenceOptions.LastAccessTimeUtcColumnName = "User_Photo_LastAccessTimeUtc";
                    this._photo.PersistenceOptions.CreationTimeUtcColumnName = "User_Photo_CreationTimeUtc";
                    this._photo.AddIdentifierValue(this.Id);
                }
                return this._photo;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SoftFluent.Samples.ComponentOne.ContactCollection Contacts
        {
            get
            {
                if ((this._contacts == null))
                {
                    if (((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true) 
                                || (this.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) == true)))
                    {
                        this._contacts = new SoftFluent.Samples.ComponentOne.ContactCollection(this);
                        return this._contacts;
                    }
                    this._contacts = SoftFluent.Samples.ComponentOne.ContactCollection.LoadByUser(this);
                }
                return this._contacts;
            }
        }
        
        protected static CodeFluent.Runtime.Rules.EmailValidator EmailValidator0
        {
            get
            {
                return SoftFluent.Samples.ComponentOne.User._emailValidator0;
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        string CodeFluent.Runtime.Utilities.IKeyable<System.String>.Key
        {
            get
            {
                return this.Email;
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.Created) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        [field:System.NonSerializedAttribute()]
        public event System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<string>> KeyChanged;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(SoftFluent.Samples.ComponentOne.User user)
        {
            if ((user == null))
            {
                return false;
            }
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return base.Equals(user);
            }
            return (this.Id.Equals(user.Id) == true);
        }
        
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            SoftFluent.Samples.ComponentOne.User user = null;
			user = obj as SoftFluent.Samples.ComponentOne.User;
            return this.Equals(user);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            SoftFluent.Samples.ComponentOne.User user = null;
user = value as SoftFluent.Samples.ComponentOne.User;
            if ((user == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(user);
            return localCompareTo;
        }
        
        public virtual int CompareTo(SoftFluent.Samples.ComponentOne.User user)
        {
            if ((user == null))
            {
                throw new System.ArgumentNullException("user");
            }
            int localCompareTo = this.Email.CompareTo(user.Email);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.ComponentOne.User.ExternalValidate", "Type \'SoftFluent.Samples.ComponentOne.User\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                string localValidate = SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.ComponentOne.User.Id.NullException", "\'Id\' property cannot be set to \'00000000-0000-0000-0000-000000000000\' for type \'S" +
                        "oftFluent.Samples.ComponentOne.User\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate);
            }
            if ((this.Email == default(string)))
            {
                string localValidate1 = SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.ComponentOne.User.Email.NullException", "\'Email\' property cannot be set to \'\' for type \'SoftFluent.Samples.ComponentOne.Us" +
                        "er\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate1);
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            if ((this.RowVersion == null))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.ComponentOne.Constants.SoftFluent_Samples_ComponentOneStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "User", "Delete");
            persistence.AddParameter("@User_Id", this.Id, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._id = CodeFluentPersistence.GetReaderValue(reader, "User_Id", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
                this.BinaryLargeObjectsReset();
                this._email = CodeFluentPersistence.GetReaderValue(reader, "User_Email", ((string)(default(string))));
                this._firstName = CodeFluentPersistence.GetReaderValue(reader, "User_FirstName", ((string)(default(string))));
                this._lastName = CodeFluentPersistence.GetReaderValue(reader, "User_LastName", ((string)(default(string))));
                this.Photo.LoadMetaData(reader);
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.RowVersion) 
                        == 0) 
                        == false))
            {
                this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.ComponentOne.User Load(System.Guid id)
        {
            if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            SoftFluent.Samples.ComponentOne.User user = new SoftFluent.Samples.ComponentOne.User();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.ComponentOne.Constants.SoftFluent_Samples_ComponentOneStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "User", "Load");
            persistence.AddParameter("@Id", id, CodeFluentPersistence.DefaultGuidValue);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    user.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    user.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return user;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
        public static SoftFluent.Samples.ComponentOne.User LoadByEmail(string email)
        {
            if ((email == default(string)))
            {
                return null;
            }
            SoftFluent.Samples.ComponentOne.User user = new SoftFluent.Samples.ComponentOne.User();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.ComponentOne.Constants.SoftFluent_Samples_ComponentOneStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "User", "LoadByEmail");
            persistence.AddParameter("@Email", email, default(string));
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    user.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    user.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return user;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.ComponentOne.Constants.SoftFluent_Samples_ComponentOneStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "User", "Load");
            persistence.AddParameter("@Id", this.Id);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.ComponentOne.Constants.SoftFluent_Samples_ComponentOneStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "User", "Save");
            persistence.AddParameter("@User_Id", this.Id, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@User_Email", this.Email, default(string));
            persistence.AddParameter("@User_FirstName", this.FirstName, default(string));
            persistence.AddParameter("@User_LastName", this.LastName, default(string));
            persistence.AddParameter("@_trackLastWriteUser", persistence.Context.User.Name);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            if ((this._photo != null))
            {
                this._photo.SaveMetaData(persistence.Context);
            }
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            if ((this._contacts != null))
            {
                this.Contacts.SaveAll();
            }
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(SoftFluent.Samples.ComponentOne.User user)
        {
            if ((user == null))
            {
                return false;
            }
            bool ret = user.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(SoftFluent.Samples.ComponentOne.User user)
        {
            bool ret = SoftFluent.Samples.ComponentOne.User.Save(user);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(SoftFluent.Samples.ComponentOne.User user)
        {
            if ((user == null))
            {
                return false;
            }
            bool ret = user.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("Id=");
            writer.Write(this.Id);
            writer.Write(",");
            writer.Write("Email=");
            writer.Write(this.Email);
            writer.Write(",");
            writer.Write("FirstName=");
            writer.Write(this.FirstName);
            writer.Write(",");
            writer.Write("LastName=");
            writer.Write(this.LastName);
            writer.Write(",");
            writer.Write("Photo=");
            ((CodeFluent.Runtime.Diagnostics.ITraceable)(this.Photo)).Trace(writer);
            writer.Write(",");
            writer.Write("Contacts=");
            if ((this._contacts != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._contacts)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        protected virtual void BinaryLargeObjectsReset()
        {
            if ((this._photo != null))
            {
                this._photo.ClearIdentifiersValues();
                this._photo.AddIdentifierValue(this.Id);
            }
        }
        
        protected virtual void BinaryLargeObjectsCopyTo(SoftFluent.Samples.ComponentOne.User user)
        {
            if ((user == null))
            {
                throw new System.ArgumentNullException("user");
            }
            if ((this._photo != null))
            {
                user._photo = this._photo;
            }
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.ComponentOne.User LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            SoftFluent.Samples.ComponentOne.User user;
            System.Guid var = ((System.Guid)(ConvertUtilities.ChangeType(key, typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            user = SoftFluent.Samples.ComponentOne.User.Load(var);
            return user;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            if (((memberName == "Email") 
                        || (memberName == null)))
            {
                CodeFluent.Runtime.Rules.ValueValidator.Validate(this, culture, "Email", results, SoftFluent.Samples.ComponentOne.User.EmailValidator0, this.Email);
            }
        }
        
        public SoftFluent.Samples.ComponentOne.User Clone(bool deep)
        {
            SoftFluent.Samples.ComponentOne.User user = new SoftFluent.Samples.ComponentOne.User();
            this.CopyTo(user, deep);
            return user;
        }
        
        public SoftFluent.Samples.ComponentOne.User Clone()
        {
            SoftFluent.Samples.ComponentOne.User localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("Id") == true))
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(dict["Id"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("Email") == true))
            {
                this.Email = ((string)(ConvertUtilities.ChangeType(dict["Email"], typeof(string), default(string))));
            }
            if ((dict.Contains("LastName") == true))
            {
                this.LastName = ((string)(ConvertUtilities.ChangeType(dict["LastName"], typeof(string), default(string))));
            }
            if ((dict.Contains("FirstName") == true))
            {
                this.FirstName = ((string)(ConvertUtilities.ChangeType(dict["FirstName"], typeof(string), default(string))));
            }
            if ((dict.Contains("Photo") == true))
            {
                this.Photo.SavePostedFile(dict["Photo"]);
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(SoftFluent.Samples.ComponentOne.User user, bool deep)
        {
            if ((user == null))
            {
                throw new System.ArgumentNullException("user");
            }
            user.Id = this.Id;
            user.Email = this.Email;
            user.LastName = this.LastName;
            user.FirstName = this.FirstName;
            user._photo = this._photo;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, user));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["Id"] = this.Id;
            dict["Email"] = this.Email;
            dict["LastName"] = this.LastName;
            dict["FirstName"] = this.FirstName;
            dict["Photo"] = this.Photo;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
        
        protected void OnCollectionKeyChanged(string key)
        {
            if ((this.KeyChanged != null))
            {
                this.KeyChanged(this, new CodeFluent.Runtime.Utilities.KeyChangedEventArgs<string>(key));
            }
        }
    }
}
