﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace ReadTestsAdventureWorks2008.EntityClasses
{
	/// <summary>Class which represents the entity 'CountryRegionCurrency', mapped on table 'AdventureWorks.Sales.CountryRegionCurrency'.</summary>
	public partial class CountryRegionCurrency : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.String	_countryRegionCode;
		private System.String	_currencyCode;
		private System.DateTime	_modifiedDate;
		private EntityRef <CountryRegion> _countryRegion;
		private EntityRef <Currency> _currency;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnCountryRegionCodeChanging(System.String value);
		partial void OnCountryRegionCodeChanged();
		partial void OnCurrencyCodeChanging(System.String value);
		partial void OnCurrencyCodeChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="CountryRegionCurrency"/> class.</summary>
		public CountryRegionCurrency()
		{
			_countryRegion = default(EntityRef<CountryRegion>);
			_currency = default(EntityRef<Currency>);
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CountryRegionCode field. Mapped on target field 'CountryRegionCode'. </summary>
		public System.String CountryRegionCode
		{
			get	{ return _countryRegionCode; }
			set
			{
				if((_countryRegionCode != value))
				{
					if(_countryRegion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnCountryRegionCodeChanging(value);
					SendPropertyChanging("CountryRegionCode");
					_countryRegionCode = value;
					SendPropertyChanged("CountryRegionCode");
					OnCountryRegionCodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the CurrencyCode field. Mapped on target field 'CurrencyCode'. </summary>
		public System.String CurrencyCode
		{
			get	{ return _currencyCode; }
			set
			{
				if((_currencyCode != value))
				{
					if(_currency.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnCurrencyCodeChanging(value);
					SendPropertyChanging("CurrencyCode");
					_currencyCode = value;
					SendPropertyChanged("CurrencyCode");
					OnCurrencyCodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'CountryRegionCurrency.CountryRegion - CountryRegion.CountryRegionCurrencies (m:1)'</summary>
		public CountryRegion CountryRegion
		{
			get { return _countryRegion.Entity; }
			set
			{
				CountryRegion previousValue = _countryRegion.Entity;
				if((previousValue != value) || (_countryRegion.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("CountryRegion");
					if(previousValue != null)
					{
						_countryRegion.Entity = null;
						previousValue.CountryRegionCurrencies.Remove(this);
					}
					_countryRegion.Entity = value;
					if(value == null)
					{
						_countryRegionCode = default(System.String);
					}
					else
					{
						value.CountryRegionCurrencies.Add(this);
						_countryRegionCode = value.CountryRegionCode;
					}
					this.SendPropertyChanged("CountryRegion");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'CountryRegionCurrency.Currency - Currency.CountryRegionCurrencies (m:1)'</summary>
		public Currency Currency
		{
			get { return _currency.Entity; }
			set
			{
				Currency previousValue = _currency.Entity;
				if((previousValue != value) || (_currency.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Currency");
					if(previousValue != null)
					{
						_currency.Entity = null;
						previousValue.CountryRegionCurrencies.Remove(this);
					}
					_currency.Entity = value;
					if(value == null)
					{
						_currencyCode = default(System.String);
					}
					else
					{
						value.CountryRegionCurrencies.Add(this);
						_currencyCode = value.CurrencyCode;
					}
					this.SendPropertyChanged("Currency");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649