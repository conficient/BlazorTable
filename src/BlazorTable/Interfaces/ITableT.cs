using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BlazorTable
{
    /// <summary>
    /// BlazorTable Interface (type-specific)
    /// </summary>
    /// <typeparam name="TableItem">The row data type</typeparam>
    /// <remarks>
    /// All row-type specific methods are defined in this interface
    /// </remarks>
    public interface ITable<TableItem> : ITable
    {
        /// <summary>
        /// List of All Available Columns
        /// </summary>
        List<IColumn<TableItem>> Columns { get; }

        /// <summary>
        /// Optional: expression to use for row class
        /// </summary>
        Expression<Func<TableItem, string>> TableRowClass { get; set; }

        /// <summary>
        /// Adds a Column to the Table
        /// </summary>
        /// <param name="column"></param>
        void AddColumn(IColumn<TableItem> column);

        /// <summary>
        /// Removes a Column from the Table
        /// </summary>
        /// <param name="column"></param>
        void RemoveColumn(IColumn<TableItem> column);

        /// <summary>
        /// IQueryable data source to display in the table
        /// </summary>
        IQueryable<TableItem> ItemsQueryable { get; set; }

        /// <summary>
        /// Collection to display in the table
        /// </summary>
        IEnumerable<TableItem> Items { get; set; }
    }
}