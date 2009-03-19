﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.ComponentModel;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Controls.Design.Common;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Windows.Design.PropertyEditing;

namespace System.Windows.Controls.DataVisualization.Design
{
    /// <summary>
    /// To register design time metadata for ColumnSeries.
    /// </summary>
    internal class ColumnSeriesMetadata : AttributeTableBuilder
    {
        /// <summary>
        /// To register design time metadata for ColumnSeries.
        /// </summary>
        public ColumnSeriesMetadata()
            : base()
        {
            AddCallback(
                typeof(ColumnSeries),
                b =>
                {
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.ActualDependentRangeAxis), 
                        new CategoryAttribute(Properties.Resources.DataVisualization));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.ActualIndependentAxis), 
                        new CategoryAttribute(Properties.Resources.DataVisualization));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.DependentRangeAxis), 
                        new CategoryAttribute(Properties.Resources.DataVisualization));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.IndependentAxis), 
                        new CategoryAttribute(Properties.Resources.DataVisualization));

                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.DataPointStyle), 
                        new CategoryAttribute(Properties.Resources.DataVisualizationStyling));

                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.DependentRangeAxis), 
                        new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.IndependentAxis), 
                        new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

                    b.AddCustomAttributes(
                        Extensions.GetMemberName<ColumnSeries>(x => x.Title),
                        PropertyValueEditor.CreateEditorAttribute(typeof(TextBoxEditor)));
                });
        }
    }
}