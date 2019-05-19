﻿using System.Collections.Generic;
using System.Linq;

namespace ParsingModels
{
   public class ModelClass
   {
      public ModelClass()
      {
         Properties = new List<ModelProperty>();
      }

      public string FullName
      {
         get
         {
            return string.Join(".", (new[] {Namespace, Name}).Where(x => x != null));
         }
      }

      public string Name { get; set; }
      public string Namespace { get; set; }
      public string CustomAttributes { get; set; }
      public string CustomInterfaces { get; set; }
      public bool IsAbstract { get; set; }
      public string BaseClass { get; set; }
      public string TableName { get; set; }
      public bool IsDependentType { get; set; }
      public List<ModelProperty> Properties { get; set; }
      public List<ModelUnidirectionalAssociation> UnidirectionalAssociations { get; set; } = new List<ModelUnidirectionalAssociation>();
      public List<ModelBidirectionalAssociation> BidirectionalAssociations { get; set; } = new List<ModelBidirectionalAssociation>();
   }
}