//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v2.1.0.4
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Testing
{
   /// <inheritdoc/>
   public partial class AllFeatureModel : DbContext
   {
      #region DbSets
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.AbstractBaseClass> AbstractBaseClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.AllPropertyTypesOptional> AllPropertyTypesOptionals { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.AllPropertyTypesRequired> AllPropertyTypesRequireds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BackingFieldTester> BackingFieldTesters { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BackingFieldTesterChild> BackingFieldTesterChilds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BaseClass> BaseClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BaseClassWithRequiredProperties> BaseClassWithRequiredProperties { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BChild> BChilds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BParentCollection> BParentCollections { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BParentOptional> BParentOptionals { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BParentRequired> BParentRequireds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.Child> Children { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.ConcreteDerivedClass> ConcreteDerivedClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.ConcreteDerivedClassWithRequiredProperties> ConcreteDerivedClassWithRequiredProperties { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.DerivedClass> DerivedClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.HiddenEntity> HiddenEntities { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.Master> Masters { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.ParserTest> ParserTests { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.QueryEntity> QueryEntities { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.RenamedColumn> RenamedColumns { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UChild> UChilds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UParentCollection> UParentCollections { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UParentOptional> UParentOptionals { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UParentRequired> UParentRequireds { get; set; }
      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Data Source=.\sqlexpress;Initial Catalog=Test;Integrated Security=True";

      /// <inheritdoc />
      public AllFeatureModel(DbContextOptions<AllFeatureModel> options) : base(options)
      {
      }

      partial void CustomInit(DbContextOptionsBuilder optionsBuilder);

      /// <inheritdoc />
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseLazyLoadingProxies();

         CustomInit(optionsBuilder);
      }

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");


         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().ToTable("AllPropertyTypesOptionals").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.BinaryAttr).HasField("_binaryAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.BooleanAttr).HasField("_booleanAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.ByteAttr).HasField("_byteAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DateTimeAttr).HasField("_dateTimeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DateTimeOffsetAttr).HasField("_dateTimeOffsetAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DecimalAttr).HasField("_decimalAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DoubleAttr).HasField("_doubleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.GuidAttr).HasField("_guidAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Int16Attr).HasField("_int16Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Int32Attr).HasField("_int32Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Int64Attr).HasField("_int64Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.SingleAttr).HasField("_singleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.StringAttr).HasField("_stringAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.TimeAttr).HasField("_timeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property<byte[]>("Timestamp").IsConcurrencyToken();
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().OwnsOne(x => x.OwnedTypeOptional).WithOwner().HasForeignKey("OwnedType_OwnedTypeOptional_Id");
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Navigation(x => x.OwnedTypeOptional).HasField("_ownedTypeOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().OwnsOne(x => x.OwnedTypeRequired).WithOwner().HasForeignKey("OwnedType_OwnedTypeRequired_Id");
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Navigation(x => x.OwnedTypeRequired).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().OwnsMany(x => x.OwnedTypeCollection).WithOwner().HasForeignKey("OwnedType_OwnedTypeCollection_Id");

         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().ToTable("AllPropertyTypesRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.BinaryAttr).IsRequired().HasField("_binaryAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.BooleanAttr).IsRequired().HasField("_booleanAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.ByteAttr).IsRequired().HasField("_byteAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DateTimeAttr).IsRequired().HasField("_dateTimeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DateTimeOffsetAttr).IsRequired().HasField("_dateTimeOffsetAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DecimalAttr).IsRequired().HasField("_decimalAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DoubleAttr).IsRequired().HasField("_doubleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.GuidAttr).IsRequired().HasField("_guidAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Int16Attr).IsRequired().HasField("_int16Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Int32Attr).IsRequired().HasField("_int32Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Int64Attr).IsRequired().HasField("_int64Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.SingleAttr).IsRequired().HasField("_singleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.StringAttr).IsRequired().HasField("_stringAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.TimeAttr).IsRequired().HasField("_timeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.BackingFieldTester>().ToTable("BackingFieldTesters").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BackingFieldTester>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.BackingFieldTester>().Property(t => t.Property1_FDC).HasField("_property1_FDC").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.BackingFieldTester>().HasOne(x => x.ToBackingFieldOnConstruction).WithOne().HasForeignKey<global::Testing.BackingFieldTester>("BackingFieldTesterChild_ToBackingFieldOnConstruction_Id");
         modelBuilder.Entity<global::Testing.BackingFieldTester>().Navigation(x => x.ToBackingFieldOnConstruction).HasField("_toBackingFieldOnConstruction").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.BackingFieldTester>().HasOne(x => x.ToBackingFieldAlways).WithOne().HasForeignKey<global::Testing.BackingFieldTester>("BackingFieldTesterChild_ToBackingFieldAlways_Id");
         modelBuilder.Entity<global::Testing.BackingFieldTester>().Navigation(x => x.ToBackingFieldAlways).HasField("_toBackingFieldAlways").UsePropertyAccessMode(PropertyAccessMode.PreferField);
         modelBuilder.Entity<global::Testing.BackingFieldTester>().HasOne(x => x.ToProperty).WithOne().HasForeignKey<global::Testing.BackingFieldTester>("BackingFieldTesterChild_ToProperty_Id");
         modelBuilder.Entity<global::Testing.BackingFieldTester>().Navigation(x => x.ToProperty).HasField("_toProperty").UsePropertyAccessMode(PropertyAccessMode.PreferProperty);

         modelBuilder.Entity<global::Testing.BackingFieldTesterChild>().ToTable("BackingFieldTesterChilds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BackingFieldTesterChild>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();


         modelBuilder.Entity<global::Testing.BaseClassWithRequiredProperties>().ToTable("BaseClassWithRequiredProperties").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BaseClassWithRequiredProperties>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.BaseClassWithRequiredProperties>().Property(t => t.Property0).IsRequired().HasField("_property0").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.BChild>().ToTable("BChilds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BChild>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.BChild>().Property(t => t.Property1a).HasMaxLength(20).HasField("_property1a").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.BChild>().HasOne(x => x.BParentRequired).WithOne(x => x.BChildOptional).HasForeignKey<global::Testing.BChild>("BParentRequired_Id");
         modelBuilder.Entity<global::Testing.BChild>().Navigation(x => x.BParentRequired).IsRequired();
         modelBuilder.Entity<global::Testing.BParentRequired>().Navigation(x => x.BChildOptional).HasField("_bChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.BChild>().HasOne(x => x.BParentRequired_1).WithOne(x => x.BChildRequired).HasForeignKey<global::Testing.BChild>("BParentRequired_1_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.BParentRequired>().Navigation(x => x.BChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.BChild>().Navigation(x => x.BParentRequired_1).IsRequired();
         modelBuilder.Entity<global::Testing.BChild>().HasOne(x => x.BParentRequired_2).WithMany(x => x.BChildCollection).HasForeignKey("BParentRequired_2_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.BChild>().Navigation(x => x.BParentRequired_2).IsRequired();
         modelBuilder.Entity<global::Testing.BChild>().HasMany(x => x.BParentCollection).WithOne(x => x.BChildRequired).HasForeignKey("BChildRequired_Id");
         modelBuilder.Entity<global::Testing.BParentCollection>().Navigation(x => x.BChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.BParentCollection>().Navigation(x => x.BChildRequired).HasField("_bChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.BChild>().HasMany(x => x.BParentCollection_2).WithOne(x => x.BChildOptional).HasForeignKey("BChildOptional_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.BParentCollection>().Navigation(x => x.BChildOptional).HasField("_bChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.BChild>().HasOne(x => x.BParentOptional).WithOne(x => x.BChildRequired).HasForeignKey<global::Testing.BParentOptional>("BChildRequired_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.BParentOptional>().Navigation(x => x.BChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.BParentOptional>().Navigation(x => x.BChildRequired).HasField("_bChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.BChild>().HasOne(x => x.BParentOptional_1).WithMany(x => x.BChildCollection).HasForeignKey("BParentOptional_1_Id");
         modelBuilder.Entity<global::Testing.BChild>().HasOne(x => x.BParentOptional_2).WithOne(x => x.BChildOptional).HasForeignKey<global::Testing.BChild>("BParentOptional_2_Id");
         modelBuilder.Entity<global::Testing.BParentOptional>().Navigation(x => x.BChildOptional).HasField("_bChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.BParentCollection>().ToTable("BParentCollections").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BParentCollection>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();

         modelBuilder.Entity<global::Testing.BParentOptional>().ToTable("BParentOptionals").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BParentOptional>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();

         modelBuilder.Entity<global::Testing.BParentRequired>().ToTable("BParentRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BParentRequired>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();

         modelBuilder.Entity<global::Testing.Child>().ToTable("Children").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.Child>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.Child>().HasOne(x => x.Parent).WithMany(x => x.Children).HasForeignKey("Parent_Id");
         modelBuilder.Entity<global::Testing.Child>().Navigation(x => x.Parent).IsRequired();

         modelBuilder.Entity<global::Testing.ConcreteDerivedClass>().Property(t => t.Property1).HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ConcreteDerivedClass>().Property(t => t.PropertyInChild).HasField("_propertyInChild").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.ConcreteDerivedClassWithRequiredProperties>().Property(t => t.Property1).IsRequired().HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.DerivedClass>().Property(t => t.Property1).HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.DerivedClass>().Property(t => t.PropertyInChild).HasField("_propertyInChild").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.HiddenEntity>().ToTable("HiddenEntities").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.HiddenEntity>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.HiddenEntity>().Property(t => t.Property1).HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.Master>().ToTable("Masters").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.Master>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.Master>().HasMany(x => x.Children).WithOne().HasForeignKey("Child_Children_Id").OnDelete(DeleteBehavior.Restrict);

         modelBuilder.Owned<global::Testing.OwnedType>();

         modelBuilder.Entity<global::Testing.ParserTest>().ToTable("ParserTests").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name1).HasField("_name1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name2).HasField("_name2").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name3).HasField("_name3").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name4).HasField("_name4").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name5).HasField("_name5").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name6).HasField("_name6").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name7).HasField("_name7").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name8).HasField("_name8").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name9).HasField("_name9").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name).HasField("_name").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name11).HasField("_name11").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name12).HasField("_name12").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name13).HasField("_name13").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name14).HasField("_name14").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name15).HasField("_name15").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name16).HasField("_name16").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name17).HasField("_name17").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name18).HasField("_name18").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         /*
         There is no table defined for QueryEntity because its IsQueryType value is set to 'true'.
         Please provide the GetQueryEntitySqlQuery() method in the DBContext class.

         private string GetQueryEntitySqlQuery()
         {
            // return the defining SQL query that pulls all the properties for global::Testing.QueryEntity
         }
         */
         modelBuilder.Entity<global::Testing.QueryEntity>().ToSqlQuery(GetQueryEntitySqlQuery());
         modelBuilder.Entity<global::Testing.QueryEntity>().Property(t => t.Id).IsRequired();
         modelBuilder.Entity<global::Testing.QueryEntity>().HasIndex(t => t.Id).IsUnique();

         modelBuilder.Entity<global::Testing.RenamedColumn>().ToTable("RenamedColumns").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.RenamedColumn>().Property(t => t.Id).IsRequired().HasColumnName("Foo").HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();

         modelBuilder.Entity<global::Testing.UChild>().ToTable("UChilds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.UChild>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();

         modelBuilder.Entity<global::Testing.UParentCollection>().ToTable("UParentCollections").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.UParentCollection>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.UParentCollection>().HasOne(x => x.UChildRequired).WithMany().OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentCollection>().Navigation(x => x.UChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.UParentCollection>().Navigation(x => x.UChildRequired).HasField("_uChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentCollection>().HasOne(x => x.UChildOptional).WithMany().OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentCollection>().Navigation(x => x.UChildOptional).HasField("_uChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.UParentOptional>().Property(t => t.PropertyInChild).HasField("_propertyInChild").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).HasDefaultValue("hello");
         modelBuilder.Entity<global::Testing.UParentOptional>().HasOne(x => x.UChildOptional).WithOne().HasForeignKey<global::Testing.UParentOptional>("UChild_UChildOptional_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentOptional>().Navigation(x => x.UChildOptional).HasField("_uChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentOptional>().HasMany(x => x.UChildCollection).WithOne().HasForeignKey("UChild_UChildCollection_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentOptional>().HasOne(x => x.UChildRequired).WithOne().HasForeignKey<global::Testing.UParentOptional>("UChildRequired_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentOptional>().Navigation(x => x.UChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.UParentOptional>().Navigation(x => x.UChildRequired).HasField("_uChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.UParentRequired>().ToTable("UParentRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.UParentRequired>().Property(t => t.Id).IsRequired().HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd();
         modelBuilder.Entity<global::Testing.UParentRequired>().Property(t => t.Property1ab).HasField("_property1ab").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentRequired>().HasOne(x => x.UChildRequired).WithOne().HasForeignKey<global::Testing.UParentRequired>("UChild_UChildRequired_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentRequired>().Navigation(x => x.UChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.UParentRequired>().Navigation(x => x.UChildRequired).HasField("_uChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentRequired>().HasMany(x => x.UChildCollection).WithOne().HasForeignKey("UChild_UChildCollection_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentRequired>().HasOne(x => x.UChildOptional).WithOne().HasForeignKey<global::Testing.UParentRequired>("UChild_UChildOptional_Id").OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<global::Testing.UParentRequired>().Navigation(x => x.UChildOptional).HasField("_uChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
