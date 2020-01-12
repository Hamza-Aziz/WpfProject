﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp16
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertetudiant(etudiant instance);
    partial void Updateetudiant(etudiant instance);
    partial void Deleteetudiant(etudiant instance);
    partial void Insertfiliere(filiere instance);
    partial void Updatefiliere(filiere instance);
    partial void Deletefiliere(filiere instance);
    partial void Insertadmin(admin instance);
    partial void Updateadmin(admin instance);
    partial void Deleteadmin(admin instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WpfApp16.Properties.Settings.Default.dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<etudiant> etudiant
		{
			get
			{
				return this.GetTable<etudiant>();
			}
		}
		
		public System.Data.Linq.Table<filiere> filiere
		{
			get
			{
				return this.GetTable<filiere>();
			}
		}
		
		public System.Data.Linq.Table<admin> admin
		{
			get
			{
				return this.GetTable<admin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.etudiant")]
	public partial class etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _cne;
		
		private string _nom;
		
		private string _prenom;
		
		private System.Nullable<System.DateTime> _dateNaiss;
		
		private string _tof;
		
		private System.Nullable<int> _id_filiere;
		
		private EntityRef<filiere> _filiere;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncneChanging(string value);
    partial void OncneChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OndateNaissChanging(System.Nullable<System.DateTime> value);
    partial void OndateNaissChanged();
    partial void OntofChanging(string value);
    partial void OntofChanged();
    partial void Onid_filiereChanging(System.Nullable<int> value);
    partial void Onid_filiereChanged();
    #endregion
		
		public etudiant()
		{
			this._filiere = default(EntityRef<filiere>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cne", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string cne
		{
			get
			{
				return this._cne;
			}
			set
			{
				if ((this._cne != value))
				{
					this.OncneChanging(value);
					this.SendPropertyChanging();
					this._cne = value;
					this.SendPropertyChanged("cne");
					this.OncneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(50)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(50)")]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateNaiss", DbType="Date")]
		public System.Nullable<System.DateTime> dateNaiss
		{
			get
			{
				return this._dateNaiss;
			}
			set
			{
				if ((this._dateNaiss != value))
				{
					this.OndateNaissChanging(value);
					this.SendPropertyChanging();
					this._dateNaiss = value;
					this.SendPropertyChanged("dateNaiss");
					this.OndateNaissChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tof", DbType="VarChar(500)")]
		public string tof
		{
			get
			{
				return this._tof;
			}
			set
			{
				if ((this._tof != value))
				{
					this.OntofChanging(value);
					this.SendPropertyChanging();
					this._tof = value;
					this.SendPropertyChanged("tof");
					this.OntofChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_filiere", DbType="Int")]
		public System.Nullable<int> id_filiere
		{
			get
			{
				return this._id_filiere;
			}
			set
			{
				if ((this._id_filiere != value))
				{
					if (this._filiere.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_filiereChanging(value);
					this.SendPropertyChanging();
					this._id_filiere = value;
					this.SendPropertyChanged("id_filiere");
					this.Onid_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="filiere_etudiant", Storage="_filiere", ThisKey="id_filiere", OtherKey="id_filiere", IsForeignKey=true)]
		public filiere filiere
		{
			get
			{
				return this._filiere.Entity;
			}
			set
			{
				filiere previousValue = this._filiere.Entity;
				if (((previousValue != value) 
							|| (this._filiere.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._filiere.Entity = null;
						previousValue.etudiant.Remove(this);
					}
					this._filiere.Entity = value;
					if ((value != null))
					{
						value.etudiant.Add(this);
						this._id_filiere = value.id_filiere;
					}
					else
					{
						this._id_filiere = default(Nullable<int>);
					}
					this.SendPropertyChanged("filiere");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.filiere")]
	public partial class filiere : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_filiere;
		
		private string _nom_filiere;
		
		private string _resp;
		
		private EntitySet<etudiant> _etudiant;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_filiereChanging(int value);
    partial void Onid_filiereChanged();
    partial void Onnom_filiereChanging(string value);
    partial void Onnom_filiereChanged();
    partial void OnrespChanging(string value);
    partial void OnrespChanged();
    #endregion
		
		public filiere()
		{
			this._etudiant = new EntitySet<etudiant>(new Action<etudiant>(this.attach_etudiant), new Action<etudiant>(this.detach_etudiant));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_filiere", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_filiere
		{
			get
			{
				return this._id_filiere;
			}
			set
			{
				if ((this._id_filiere != value))
				{
					this.Onid_filiereChanging(value);
					this.SendPropertyChanging();
					this._id_filiere = value;
					this.SendPropertyChanged("id_filiere");
					this.Onid_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom_filiere", DbType="VarChar(50)")]
		public string nom_filiere
		{
			get
			{
				return this._nom_filiere;
			}
			set
			{
				if ((this._nom_filiere != value))
				{
					this.Onnom_filiereChanging(value);
					this.SendPropertyChanging();
					this._nom_filiere = value;
					this.SendPropertyChanged("nom_filiere");
					this.Onnom_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_resp", DbType="VarChar(50)")]
		public string resp
		{
			get
			{
				return this._resp;
			}
			set
			{
				if ((this._resp != value))
				{
					this.OnrespChanging(value);
					this.SendPropertyChanging();
					this._resp = value;
					this.SendPropertyChanged("resp");
					this.OnrespChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="filiere_etudiant", Storage="_etudiant", ThisKey="id_filiere", OtherKey="id_filiere")]
		public EntitySet<etudiant> etudiant
		{
			get
			{
				return this._etudiant;
			}
			set
			{
				this._etudiant.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_etudiant(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.filiere = this;
		}
		
		private void detach_etudiant(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.filiere = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin")]
	public partial class admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _password;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591