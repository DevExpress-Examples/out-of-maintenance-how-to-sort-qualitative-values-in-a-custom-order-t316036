<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/QualitativeScaleCustomSortOrderSample/Form1.cs) (VB: [Form1.vb](./VB/QualitativeScaleCustomSortOrderSample/Form1.vb))**
* [NumberComparer.cs](./CS/QualitativeScaleCustomSortOrderSample/NumberComparer.cs) (VB: [NumberComparer.vb](./VB/QualitativeScaleCustomSortOrderSample/NumberComparer.vb))
<!-- default file list end -->
# How to sort qualitative values in a custom order


<p>This example demonstrates how to implement a custom <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisBase.QualitativeScaleComparer.property">QualitativeScaleComparer</a> to sort the qualitative scale in a certain order.</p>


<h3>Description</h3>

To do this, assign an object of a class implementing the <strong>System.Collections.IComparer</strong> interface to the <strong>AxisBase.QualitativeScaleComparer</strong> property.

<br/>


