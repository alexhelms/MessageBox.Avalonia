using MessageBox.Avalonia.Models;
using System.Collections.Generic;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxCustomParams : AbstractMessageBoxParams
    {
        /// <summary>
        /// Icon of window
        /// </summary>
        public Icon Icon { get; set; } = Icon.None;
        /// <summary>
        /// Buttons of message box
        /// </summary>
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
    }
}