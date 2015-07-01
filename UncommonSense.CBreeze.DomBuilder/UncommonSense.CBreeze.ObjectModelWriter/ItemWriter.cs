﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.ObjectModelBuilder;
using UncommonSense.CSharp;

namespace UncommonSense.CBreeze.ObjectModelWriter
{
	public static class ItemWriter
	{
		public static void WriteToFolder(this Item item, string folderName)
		{
			var @class = new Class(Visibility.Public, item.Name, item.BaseTypeName);
			@class.Abstract = item.Abstract;
			@class.AddConstructor(item);
			@class.OverrideToString(item);
			@class.AddAttributeProperties(item);

			new CompilationUnit(new Namespace(item.ObjectModel.Namespace, @class)).WriteTo(Path.Combine(folderName, @class.FileName));
		}

		public static void AddConstructor(this Class @class, Item item)
		{
			ConstructorInitializer initializer = null;
			var inheritedIdentifiers = item.InheritedAttributes.OfType<Identifier>();

			if (inheritedIdentifiers.Any())
			{
				initializer = new ConstructorBaseInitializer();

				foreach (var identifier in inheritedIdentifiers)
				{
					var argument = new ExpressionArgument(identifier.InternalName);
					initializer.Arguments.Add(argument);
				}
			}

			var ctor = new Constructor(Visibility.Public, item.Name, initializer, null);

			// Parameters
			foreach (var identifier in item.AllAttributes.OfType<Identifier>())
			{
				var parameter = new FixedParameter(identifier.InternalName, identifier.TypeName);
				ctor.Parameters.Add(parameter);
			}

			// Statements
			foreach (var identifier in item.Attributes.OfType<Identifier>())
			{
				ctor.CodeBlock.Statements.AddFormat("{0} = {1};", identifier.Name, identifier.InternalName);
			}

			foreach (var childNode in item.Attributes.OfType<ChildNode>())
			{
				ctor.CodeBlock.Statements.AddFormat("{0} = new {1}(this);", childNode.Name, childNode.TypeName);
			}

			@class.Constructors.Add(ctor);
		}

		public static void OverrideToString(this Class @class, Item item)
		{
			var method = new Method(Visibility.Public, "ToString", "string", null);
			method.Overriding = Overriding.Override;
			method.CodeBlock.Statements.AddFormat("return \"{0}\";", item.Name);
			@class.Methods.Add(method);
		}

		public static void AddAttributeProperties(this Class @class, Item item)
		{
			foreach (var attribute in item.Attributes)
			{
				var setterVisibility = (attribute is ChildNode || attribute is Identifier) ? AccessorVisibility.Internal : AccessorVisibility.Unspecified;

				var getter = new PropertyAccessor(AccessorVisibility.Unspecified, null);
				var setter = new PropertyAccessor(setterVisibility, null);
				var property = new UncommonSense.CSharp.Property(Visibility.Public, attribute.Name, attribute.TypeName, getter, setter);

				@class.Properties.Add(property);
			}
		}
	}
}
