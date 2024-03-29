﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRegister.Repo.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CarProjectDatbase")]
	public partial class SQLDataAccessDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertVehicle(Vehicle instance);
    partial void UpdateVehicle(Vehicle instance);
    partial void DeleteVehicle(Vehicle instance);
    partial void InsertVehicleService(VehicleService instance);
    partial void UpdateVehicleService(VehicleService instance);
    partial void DeleteVehicleService(VehicleService instance);
    #endregion
		
		public SQLDataAccessDataContext() : 
				base(global::CarRegister.Repo.Properties.Settings.Default.CarProjectDatbaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataAccessDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataAccessDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataAccessDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataAccessDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Vehicle> Vehicles
		{
			get
			{
				return this.GetTable<Vehicle>();
			}
		}
		
		public System.Data.Linq.Table<VehicleService> VehicleServices
		{
			get
			{
				return this.GetTable<VehicleService>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Vehicle")]
	public partial class Vehicle : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _RegistrationNumber;
		
		private string _Model;
		
		private string _Brand;
		
		private int _Weight;
		
		private string _VehicleType;
		
		private int _ModelYear;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnRegistrationNumberChanging(string value);
    partial void OnRegistrationNumberChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnWeightChanging(int value);
    partial void OnWeightChanged();
    partial void OnVehicleTypeChanging(string value);
    partial void OnVehicleTypeChanged();
    partial void OnModelYearChanging(int value);
    partial void OnModelYearChanged();
    #endregion
		
		public Vehicle()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string RegistrationNumber
		{
			get
			{
				return this._RegistrationNumber;
			}
			set
			{
				if ((this._RegistrationNumber != value))
				{
					this.OnRegistrationNumberChanging(value);
					this.SendPropertyChanging();
					this._RegistrationNumber = value;
					this.SendPropertyChanged("RegistrationNumber");
					this.OnRegistrationNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Int NOT NULL")]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string VehicleType
		{
			get
			{
				return this._VehicleType;
			}
			set
			{
				if ((this._VehicleType != value))
				{
					this.OnVehicleTypeChanging(value);
					this.SendPropertyChanging();
					this._VehicleType = value;
					this.SendPropertyChanged("VehicleType");
					this.OnVehicleTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelYear", DbType="Int NOT NULL")]
		public int ModelYear
		{
			get
			{
				return this._ModelYear;
			}
			set
			{
				if ((this._ModelYear != value))
				{
					this.OnModelYearChanging(value);
					this.SendPropertyChanging();
					this._ModelYear = value;
					this.SendPropertyChanged("ModelYear");
					this.OnModelYearChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VehicleService")]
	public partial class VehicleService : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _VehicleRegistrationNumber;
		
		private string _Description;
		
		private System.DateTime _Time;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnVehicleRegistrationNumberChanging(string value);
    partial void OnVehicleRegistrationNumberChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnTimeChanging(System.DateTime value);
    partial void OnTimeChanged();
    #endregion
		
		public VehicleService()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleRegistrationNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string VehicleRegistrationNumber
		{
			get
			{
				return this._VehicleRegistrationNumber;
			}
			set
			{
				if ((this._VehicleRegistrationNumber != value))
				{
					this.OnVehicleRegistrationNumberChanging(value);
					this.SendPropertyChanging();
					this._VehicleRegistrationNumber = value;
					this.SendPropertyChanged("VehicleRegistrationNumber");
					this.OnVehicleRegistrationNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(250)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime NOT NULL")]
		public System.DateTime Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
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
