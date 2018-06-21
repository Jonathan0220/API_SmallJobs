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

namespace TM_webapi_smalljobs.Repository
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TM_SMALLJOBS")]
	public partial class SmallJobsSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public SmallJobsSqlDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TM_SMALLJOBSConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SmallJobsSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SmallJobsSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SmallJobsSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SmallJobsSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_AltaVacante")]
		public int sp_AltaVacante([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreVacante", DbType="VarChar(50)")] string nombreVacante, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="VarChar(50)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TipoPedido", DbType="VarChar(50)")] string tipoPedido, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumContacto", DbType="VarChar(50)")] string numContacto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(50)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaInicio", DbType="VarChar(50)")] string fechaInicio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaFin", DbType="VarChar(50)")] string fechaFin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idUsuario, nombreVacante, descripcion, tipoPedido, numContacto, direccion, fechaInicio, fechaFin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ConsultaVacante")]
		public ISingleResult<sp_ConsultaVacanteResult> sp_ConsultaVacante([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreVacante", DbType="VarChar(50)")] string nombreVacante)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreVacante);
			return ((ISingleResult<sp_ConsultaVacanteResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_ConsultaVacanteResult
	{
		
		private int _idVacante;
		
		private System.Nullable<int> _idUsuario;
		
		private string _NombreVacante;
		
		private string _Descripcion;
		
		private string _TipoPedido;
		
		private string _NumContacto;
		
		private string _Direccion;
		
		private string _FechaInicio;
		
		private string _FechaFin;
		
		public sp_ConsultaVacanteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVacante", DbType="Int NOT NULL")]
		public int idVacante
		{
			get
			{
				return this._idVacante;
			}
			set
			{
				if ((this._idVacante != value))
				{
					this._idVacante = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int")]
		public System.Nullable<int> idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this._idUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreVacante", DbType="VarChar(50)")]
		public string NombreVacante
		{
			get
			{
				return this._NombreVacante;
			}
			set
			{
				if ((this._NombreVacante != value))
				{
					this._NombreVacante = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoPedido", DbType="VarChar(50)")]
		public string TipoPedido
		{
			get
			{
				return this._TipoPedido;
			}
			set
			{
				if ((this._TipoPedido != value))
				{
					this._TipoPedido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumContacto", DbType="VarChar(50)")]
		public string NumContacto
		{
			get
			{
				return this._NumContacto;
			}
			set
			{
				if ((this._NumContacto != value))
				{
					this._NumContacto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaInicio", DbType="VarChar(50)")]
		public string FechaInicio
		{
			get
			{
				return this._FechaInicio;
			}
			set
			{
				if ((this._FechaInicio != value))
				{
					this._FechaInicio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaFin", DbType="VarChar(50)")]
		public string FechaFin
		{
			get
			{
				return this._FechaFin;
			}
			set
			{
				if ((this._FechaFin != value))
				{
					this._FechaFin = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
