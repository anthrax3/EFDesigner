﻿  
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;

using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;

namespace Sawczyn.EFDesigner.EFModel.ExtensionEnablement
{ 
	/// <summary>
	/// GestureExtensionController base class to import and invoke GestureExtensions 
	/// </summary>	
	internal abstract class EFModelGestureExtensionControllerBase : GestureExtensionController
	{
		/// <summary>
		/// This registrar will filter out GestureExtensions that do not provide an item of metadata with this value as its key.
		/// </summary>
		protected override String MetadataFilter
		{
			[DebuggerStepThrough]
			get
			{
				return  EFModelExtensionFilter.MefMetadataFilter;
			}
		}
	}
	
	/// <summary>
	/// GestureExtensionController class to import and invoke GestureExtensions 
	/// </summary>
	/// <remarks>
	/// Double-derived to allow customizations by Dsl Authors.
	/// </remarks>	
	internal class EFModelGestureExtensionController : EFModelGestureExtensionControllerBase
	{
	}
}
