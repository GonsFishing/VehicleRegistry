﻿//#pragma warning disable 1591
////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by a tool.
////     Runtime Version:4.0.30319.42000
////
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------

//namespace CarRegister.Repo.DataAccess
//{
//	using System.Data.Linq;
//	using System.Data.Linq.Mapping;
//	using System.Data;
//	using System.Collections.Generic;
//	using System.Reflection;
//	using System.Linq;
//	using System.Linq.Expressions;
//	using System.ComponentModel;
//	using System;
	
	
//	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="skolprojekt2020DB")]
//	public partial class AzureDataBaseAccessDataContext : System.Data.Linq.DataContext
//	{
		
//		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
//    #region Extensibility Method Definitions
//    partial void OnCreated();
//    partial void InsertCar(Car instance);
//    partial void UpdateCar(Car instance);
//    partial void DeleteCar(Car instance);
//    partial void InsertCar_CarService(Car_CarService instance);
//    partial void UpdateCar_CarService(Car_CarService instance);
//    partial void DeleteCar_CarService(Car_CarService instance);
//    partial void InsertCarService(CarService instance);
//    partial void UpdateCarService(CarService instance);
//    partial void DeleteCarService(CarService instance);
//    #endregion
		
//		public AzureDataBaseAccessDataContext() : 
//				base(global::CarRegister.Repo.Properties.Settings.Default.skolprojekt2020DBConnectionString1, mappingSource)
//		{
//			OnCreated();
//		}
		
//		public AzureDataBaseAccessDataContext(string connection) : 
//				base(connection, mappingSource)
//		{
//			OnCreated();
//		}
		
//		public AzureDataBaseAccessDataContext(System.Data.IDbConnection connection) : 
//				base(connection, mappingSource)
//		{
//			OnCreated();
//		}
		
//		public AzureDataBaseAccessDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
//				base(connection, mappingSource)
//		{
//			OnCreated();
//		}
		
//		public AzureDataBaseAccessDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
//				base(connection, mappingSource)
//		{
//			OnCreated();
//		}
		
//		public System.Data.Linq.Table<Car> Cars
//		{
//			get
//			{
//				return this.GetTable<Car>();
//			}
//		}
		
//		public System.Data.Linq.Table<Car_CarService> Car_CarServices
//		{
//			get
//			{
//				return this.GetTable<Car_CarService>();
//			}
//		}
		
//		public System.Data.Linq.Table<CarService> CarServices
//		{
//			get
//			{
//				return this.GetTable<CarService>();
//			}
//		}
//	}
	
//	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Car")]
//	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
//	{
		
//		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
//		//private int _ID;
		
//		//private string _Model;
		
//		//private string _CarBrand;
		
//		//private string _CarType;
		
//		private int _CarWeight;
		
//		private System.DateTime _Year;
		
//		private string _LicensePlateNumber;
		
//		private bool _IsYearlyFeePaid;
		
//		private bool _CarTrafficReady;
		
//		private EntitySet<Car_CarService> _Car_CarServices;
		
//    #region Extensibility Method Definitions
//    partial void OnLoaded();
//    partial void OnValidate(System.Data.Linq.ChangeAction action);
//    partial void OnCreated();
//    partial void OnIDChanging(int value);
//    partial void OnIDChanged();
//    partial void OnModelChanging(string value);
//    partial void OnModelChanged();
//    partial void OnCarBrandChanging(string value);
//    partial void OnCarBrandChanged();
//    partial void OnCarTypeChanging(string value);
//    partial void OnCarTypeChanged();
//    partial void OnCarWeightChanging(int value);
//    partial void OnCarWeightChanged();
//    partial void OnYearChanging(System.DateTime value);
//    partial void OnYearChanged();
//    partial void OnLicensePlateNumberChanging(string value);
//    partial void OnLicensePlateNumberChanged();
//    partial void OnIsYearlyFeePaidChanging(bool value);
//    partial void OnIsYearlyFeePaidChanged();
//    partial void OnCarTrafficReadyChanging(bool value);
//    partial void OnCarTrafficReadyChanged();
//    #endregion
		
//		public Car()
//		{
//			this._Car_CarServices = new EntitySet<Car_CarService>(new Action<Car_CarService>(this.attach_Car_CarServices), new Action<Car_CarService>(this.detach_Car_CarServices));
//			OnCreated();
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
//		public int ID
//		{
//			get
//			{
//				return this._ID;
//			}
//			set
//			{
//				if ((this._ID != value))
//				{
//					this.OnIDChanging(value);
//					this.SendPropertyChanging();
//					this._ID = value;
//					this.SendPropertyChanged("ID");
//					this.OnIDChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
//		public string Model
//		{
//			get
//			{
//				return this._Model;
//			}
//			set
//			{
//				if ((this._Model != value))
//				{
//					this.OnModelChanging(value);
//					this.SendPropertyChanging();
//					this._Model = value;
//					this.SendPropertyChanged("Model");
//					this.OnModelChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarBrand", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
//		public string CarBrand
//		{
//			get
//			{
//				return this._CarBrand;
//			}
//			set
//			{
//				if ((this._CarBrand != value))
//				{
//					this.OnCarBrandChanging(value);
//					this.SendPropertyChanging();
//					this._CarBrand = value;
//					this.SendPropertyChanged("CarBrand");
//					this.OnCarBrandChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
//		public string CarType
//		{
//			get
//			{
//				return this._CarType;
//			}
//			set
//			{
//				if ((this._CarType != value))
//				{
//					this.OnCarTypeChanging(value);
//					this.SendPropertyChanging();
//					this._CarType = value;
//					this.SendPropertyChanged("CarType");
//					this.OnCarTypeChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarWeight", DbType="Int NOT NULL")]
//		public int CarWeight
//		{
//			get
//			{
//				return this._CarWeight;
//			}
//			set
//			{
//				if ((this._CarWeight != value))
//				{
//					this.OnCarWeightChanging(value);
//					this.SendPropertyChanging();
//					this._CarWeight = value;
//					this.SendPropertyChanged("CarWeight");
//					this.OnCarWeightChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="DateTime NOT NULL")]
//		public System.DateTime Year
//		{
//			get
//			{
//				return this._Year;
//			}
//			set
//			{
//				if ((this._Year != value))
//				{
//					this.OnYearChanging(value);
//					this.SendPropertyChanging();
//					this._Year = value;
//					this.SendPropertyChanged("Year");
//					this.OnYearChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LicensePlateNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
//		public string LicensePlateNumber
//		{
//			get
//			{
//				return this._LicensePlateNumber;
//			}
//			set
//			{
//				if ((this._LicensePlateNumber != value))
//				{
//					this.OnLicensePlateNumberChanging(value);
//					this.SendPropertyChanging();
//					this._LicensePlateNumber = value;
//					this.SendPropertyChanged("LicensePlateNumber");
//					this.OnLicensePlateNumberChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsYearlyFeePaid", DbType="Bit NOT NULL")]
//		public bool IsYearlyFeePaid
//		{
//			get
//			{
//				return this._IsYearlyFeePaid;
//			}
//			set
//			{
//				if ((this._IsYearlyFeePaid != value))
//				{
//					this.OnIsYearlyFeePaidChanging(value);
//					this.SendPropertyChanging();
//					this._IsYearlyFeePaid = value;
//					this.SendPropertyChanged("IsYearlyFeePaid");
//					this.OnIsYearlyFeePaidChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarTrafficReady", DbType="Bit NOT NULL")]
//		public bool CarTrafficReady
//		{
//			get
//			{
//				return this._CarTrafficReady;
//			}
//			set
//			{
//				if ((this._CarTrafficReady != value))
//				{
//					this.OnCarTrafficReadyChanging(value);
//					this.SendPropertyChanging();
//					this._CarTrafficReady = value;
//					this.SendPropertyChanged("CarTrafficReady");
//					this.OnCarTrafficReadyChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Car_CarService", Storage="_Car_CarServices", ThisKey="ID", OtherKey="CarID")]
//		public EntitySet<Car_CarService> Car_CarServices
//		{
//			get
//			{
//				return this._Car_CarServices;
//			}
//			set
//			{
//				this._Car_CarServices.Assign(value);
//			}
//		}
		
//		public event PropertyChangingEventHandler PropertyChanging;
		
//		public event PropertyChangedEventHandler PropertyChanged;
		
//		protected virtual void SendPropertyChanging()
//		{
//			if ((this.PropertyChanging != null))
//			{
//				this.PropertyChanging(this, emptyChangingEventArgs);
//			}
//		}
		
//		protected virtual void SendPropertyChanged(String propertyName)
//		{
//			if ((this.PropertyChanged != null))
//			{
//				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//			}
//		}
		
//		private void attach_Car_CarServices(Car_CarService entity)
//		{
//			this.SendPropertyChanging();
//			entity.Car = this;
//		}
		
//		private void detach_Car_CarServices(Car_CarService entity)
//		{
//			this.SendPropertyChanging();
//			entity.Car = null;
//		}
//	}
	
//	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Car_CarService")]
//	public partial class Car_CarService : INotifyPropertyChanging, INotifyPropertyChanged
//	{
		
//		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
//		private int _ID;
		
//		private int _CarID;
		
//		private int _CarServiceID;
		
//		private EntityRef<Car> _Car;
		
//		private EntityRef<CarService> _CarService;
		
//    #region Extensibility Method Definitions
//    partial void OnLoaded();
//    partial void OnValidate(System.Data.Linq.ChangeAction action);
//    partial void OnCreated();
//    partial void OnIDChanging(int value);
//    partial void OnIDChanged();
//    partial void OnCarIDChanging(int value);
//    partial void OnCarIDChanged();
//    partial void OnCarServiceIDChanging(int value);
//    partial void OnCarServiceIDChanged();
//    #endregion
		
//		public Car_CarService()
//		{
//			this._Car = default(EntityRef<Car>);
//			this._CarService = default(EntityRef<CarService>);
//			OnCreated();
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
//		public int ID
//		{
//			get
//			{
//				return this._ID;
//			}
//			set
//			{
//				if ((this._ID != value))
//				{
//					this.OnIDChanging(value);
//					this.SendPropertyChanging();
//					this._ID = value;
//					this.SendPropertyChanged("ID");
//					this.OnIDChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarID", DbType="Int NOT NULL")]
//		public int CarID
//		{
//			get
//			{
//				return this._CarID;
//			}
//			set
//			{
//				if ((this._CarID != value))
//				{
//					if (this._Car.HasLoadedOrAssignedValue)
//					{
//						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
//					}
//					this.OnCarIDChanging(value);
//					this.SendPropertyChanging();
//					this._CarID = value;
//					this.SendPropertyChanged("CarID");
//					this.OnCarIDChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarServiceID", DbType="Int NOT NULL")]
//		public int CarServiceID
//		{
//			get
//			{
//				return this._CarServiceID;
//			}
//			set
//			{
//				if ((this._CarServiceID != value))
//				{
//					if (this._CarService.HasLoadedOrAssignedValue)
//					{
//						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
//					}
//					this.OnCarServiceIDChanging(value);
//					this.SendPropertyChanging();
//					this._CarServiceID = value;
//					this.SendPropertyChanged("CarServiceID");
//					this.OnCarServiceIDChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Car_CarService", Storage="_Car", ThisKey="CarID", OtherKey="ID", IsForeignKey=true)]
//		public Car Car
//		{
//			get
//			{
//				return this._Car.Entity;
//			}
//			set
//			{
//				Car previousValue = this._Car.Entity;
//				if (((previousValue != value) 
//							|| (this._Car.HasLoadedOrAssignedValue == false)))
//				{
//					this.SendPropertyChanging();
//					if ((previousValue != null))
//					{
//						this._Car.Entity = null;
//						previousValue.Car_CarServices.Remove(this);
//					}
//					this._Car.Entity = value;
//					if ((value != null))
//					{
//						value.Car_CarServices.Add(this);
//						this._CarID = value.ID;
//					}
//					else
//					{
//						this._CarID = default(int);
//					}
//					this.SendPropertyChanged("Car");
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarService_Car_CarService", Storage="_CarService", ThisKey="CarServiceID", OtherKey="ID", IsForeignKey=true)]
//		public CarService CarService
//		{
//			get
//			{
//				return this._CarService.Entity;
//			}
//			set
//			{
//				CarService previousValue = this._CarService.Entity;
//				if (((previousValue != value) 
//							|| (this._CarService.HasLoadedOrAssignedValue == false)))
//				{
//					this.SendPropertyChanging();
//					if ((previousValue != null))
//					{
//						this._CarService.Entity = null;
//						previousValue.Car_CarServices.Remove(this);
//					}
//					this._CarService.Entity = value;
//					if ((value != null))
//					{
//						value.Car_CarServices.Add(this);
//						this._CarServiceID = value.ID;
//					}
//					else
//					{
//						this._CarServiceID = default(int);
//					}
//					this.SendPropertyChanged("CarService");
//				}
//			}
//		}
		
//		public event PropertyChangingEventHandler PropertyChanging;
		
//		public event PropertyChangedEventHandler PropertyChanged;
		
//		protected virtual void SendPropertyChanging()
//		{
//			if ((this.PropertyChanging != null))
//			{
//				this.PropertyChanging(this, emptyChangingEventArgs);
//			}
//		}
		
//		protected virtual void SendPropertyChanged(String propertyName)
//		{
//			if ((this.PropertyChanged != null))
//			{
//				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//			}
//		}
//	}
	
//	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CarService")]
//	public partial class CarService : INotifyPropertyChanging, INotifyPropertyChanged
//	{
		
//		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
//		private int _ID;
		
//		private bool _IsServiceCompleted;
		
//		private string _ServiceInfo;
		
//		private EntitySet<Car_CarService> _Car_CarServices;
		
//    #region Extensibility Method Definitions
//    partial void OnLoaded();
//    partial void OnValidate(System.Data.Linq.ChangeAction action);
//    partial void OnCreated();
//    partial void OnIDChanging(int value);
//    partial void OnIDChanged();
//    partial void OnIsServiceCompletedChanging(bool value);
//    partial void OnIsServiceCompletedChanged();
//    partial void OnServiceInfoChanging(string value);
//    partial void OnServiceInfoChanged();
//    #endregion
		
//		public CarService()
//		{
//			this._Car_CarServices = new EntitySet<Car_CarService>(new Action<Car_CarService>(this.attach_Car_CarServices), new Action<Car_CarService>(this.detach_Car_CarServices));
//			OnCreated();
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
//		public int ID
//		{
//			get
//			{
//				return this._ID;
//			}
//			set
//			{
//				if ((this._ID != value))
//				{
//					this.OnIDChanging(value);
//					this.SendPropertyChanging();
//					this._ID = value;
//					this.SendPropertyChanged("ID");
//					this.OnIDChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsServiceCompleted", DbType="Bit NOT NULL")]
//		public bool IsServiceCompleted
//		{
//			get
//			{
//				return this._IsServiceCompleted;
//			}
//			set
//			{
//				if ((this._IsServiceCompleted != value))
//				{
//					this.OnIsServiceCompletedChanging(value);
//					this.SendPropertyChanging();
//					this._IsServiceCompleted = value;
//					this.SendPropertyChanged("IsServiceCompleted");
//					this.OnIsServiceCompletedChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceInfo", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
//		public string ServiceInfo
//		{
//			get
//			{
//				return this._ServiceInfo;
//			}
//			set
//			{
//				if ((this._ServiceInfo != value))
//				{
//					this.OnServiceInfoChanging(value);
//					this.SendPropertyChanging();
//					this._ServiceInfo = value;
//					this.SendPropertyChanged("ServiceInfo");
//					this.OnServiceInfoChanged();
//				}
//			}
//		}
		
//		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarService_Car_CarService", Storage="_Car_CarServices", ThisKey="ID", OtherKey="CarServiceID")]
//		public EntitySet<Car_CarService> Car_CarServices
//		{
//			get
//			{
//				return this._Car_CarServices;
//			}
//			set
//			{
//				this._Car_CarServices.Assign(value);
//			}
//		}
		
//		public event PropertyChangingEventHandler PropertyChanging;
		
//		public event PropertyChangedEventHandler PropertyChanged;
		
//		protected virtual void SendPropertyChanging()
//		{
//			if ((this.PropertyChanging != null))
//			{
//				this.PropertyChanging(this, emptyChangingEventArgs);
//			}
//		}
		
//		protected virtual void SendPropertyChanged(String propertyName)
//		{
//			if ((this.PropertyChanged != null))
//			{
//				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//			}
//		}
		
//		private void attach_Car_CarServices(Car_CarService entity)
//		{
//			this.SendPropertyChanging();
//			entity.CarService = this;
//		}
		
//		private void detach_Car_CarServices(Car_CarService entity)
//		{
//			this.SendPropertyChanging();
//			entity.CarService = null;
//		}
//	}
//}
//#pragma warning restore 1591
