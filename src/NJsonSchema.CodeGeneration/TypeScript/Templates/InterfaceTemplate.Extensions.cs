﻿//-----------------------------------------------------------------------
// <copyright file="InterfaceTemplate.Extensions.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/rsuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NJsonSchema.CodeGeneration.TypeScript.Templates
{
    internal partial class InterfaceTemplate : ITemplate
    {
        public InterfaceTemplate(object model)
        {
            Model = model;
        }

        public dynamic Model { get; }
        
        public string Render()
        {
            return ConversionUtilities.TrimWhiteSpaces(TransformText());
        }
    }
}
