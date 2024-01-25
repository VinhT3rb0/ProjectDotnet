﻿using Xunit;

namespace MaterialDesignThemes.Wpf.Tests;

public class DataGridAssistTests
{
    private readonly DataGrid _testElement;

    public DataGridAssistTests()
    {
        _testElement = new DataGrid();
    }

    [StaFact]
    public void TestAutoGeneratedCheckBoxStyleProperty()
    {
        // Assert defaults
        Assert.Equal("AutoGeneratedCheckBoxStyle", DataGridAssist.AutoGeneratedCheckBoxStyleProperty.Name);
        Assert.Equal(default, DataGridAssist.GetAutoGeneratedCheckBoxStyle(_testElement));

        // Assert setting works
        var style = new Style();
        DataGridAssist.SetAutoGeneratedCheckBoxStyle(_testElement, style);
        Assert.Equal(style, DataGridAssist.GetAutoGeneratedCheckBoxStyle(_testElement));
    }

    [StaFact]
    public void TestAutoGeneratedEditingCheckBoxStyleProperty()
    {
        // Assert defaults
        Assert.Equal("AutoGeneratedEditingCheckBoxStyle", DataGridAssist.AutoGeneratedEditingCheckBoxStyleProperty.Name);
        Assert.Equal(default, DataGridAssist.GetAutoGeneratedEditingCheckBoxStyle(_testElement));

        // Assert setting works
        var style = new Style();
        DataGridAssist.SetAutoGeneratedEditingCheckBoxStyle(_testElement, style);
        Assert.Equal(style, DataGridAssist.GetAutoGeneratedEditingCheckBoxStyle(_testElement));
    }

    [StaFact]
    public void TestAutoGeneratedTextStyleProperty()
    {
        // Assert defaults
        Assert.Equal("AutoGeneratedTextStyle", DataGridAssist.AutoGeneratedTextStyleProperty.Name);
        Assert.Equal(default, DataGridAssist.GetAutoGeneratedTextStyle(_testElement));

        // Assert setting works
        var style = new Style();
        DataGridAssist.SetAutoGeneratedTextStyle(_testElement, style);
        Assert.Equal(style, DataGridAssist.GetAutoGeneratedTextStyle(_testElement));
    }

    [StaFact]
    public void TestAutoGeneratedEditingTextStyleProperty()
    {
        // Assert defaults
        Assert.Equal("AutoGeneratedEditingTextStyle", DataGridAssist.AutoGeneratedEditingTextStyleProperty.Name);
        Assert.Equal(default, DataGridAssist.GetAutoGeneratedEditingTextStyle(_testElement));

        // Assert setting works
        var style = new Style();
        DataGridAssist.SetAutoGeneratedEditingTextStyle(_testElement, style);
        Assert.Equal(style, DataGridAssist.GetAutoGeneratedEditingTextStyle(_testElement));
    }

    [StaFact]
    public void TestCellPaddingProperty()
    {
        // Assert defaults
        var defaultCellPadding = new Thickness(16, 8, 16, 8);
        Assert.Equal("CellPadding", DataGridAssist.CellPaddingProperty.Name);
        Assert.Equal(defaultCellPadding, DataGridAssist.GetCellPadding(_testElement));

        // Assert setting works
        var thickness = new Thickness(2, 8, 1, 8);
        DataGridAssist.SetCellPadding(_testElement, thickness);
        Assert.Equal(thickness, DataGridAssist.GetCellPadding(_testElement));
    }

    [StaFact]
    public void TestColumnHeaderPaddingProperty()
    {
        // Assert defaults
        var defaultColumnHeaderPadding = new Thickness(16, 10, 16, 10);
        Assert.Equal("ColumnHeaderPadding", DataGridAssist.ColumnHeaderPaddingProperty.Name);
        Assert.Equal(defaultColumnHeaderPadding, DataGridAssist.GetColumnHeaderPadding(_testElement));

        // Assert setting works
        var thickness = new Thickness(1, 13, 144, -4);
        DataGridAssist.SetColumnHeaderPadding(_testElement, thickness);
        Assert.Equal(thickness, DataGridAssist.GetColumnHeaderPadding(_testElement));
    }

    [StaFact]
    public void TestEnableEditBoxAssistProperty()
    {
        // Assert defaults
        Assert.Equal("EnableEditBoxAssist", DataGridAssist.EnableEditBoxAssistProperty.Name);
        Assert.Equal(default, DataGridAssist.GetEnableEditBoxAssist(_testElement));

        // Assert setting works
        DataGridAssist.SetEnableEditBoxAssist(_testElement, true);
        Assert.True(DataGridAssist.GetEnableEditBoxAssist(_testElement));
    }

    [StaFact]
    public void TestCornerRadiusProperty()
    {
        // Assert defaults
        var defaultCornerRadius = new CornerRadius(4);
        Assert.Equal("CornerRadius", DataGridAssist.CornerRadiusProperty.Name);
        Assert.Equal(defaultCornerRadius, DataGridAssist.GetCornerRadius(_testElement));

        // Assert setting works
        var cornerRadius = new CornerRadius(11);
        DataGridAssist.SetCornerRadius(_testElement, cornerRadius);
        Assert.Equal(cornerRadius, DataGridAssist.GetCornerRadius(_testElement));
    }

}
