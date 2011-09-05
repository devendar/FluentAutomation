﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAutomation.API.Providers;
using FluentAutomation.API.Interfaces;

namespace FluentAutomation.API.FieldHandlers
{
    public class DraggedFieldHandler
    {
        private AutomationProvider _automation = null;
        private string _dragFieldSelector = string.Empty;

        internal DraggedFieldHandler(AutomationProvider automation, string fieldSelector)
        {
            _automation = automation;
            _dragFieldSelector = fieldSelector;
        }

        public void To(string fieldSelector)
        {
            var element = _automation.GetElement(_dragFieldSelector);
            element.DragTo(_automation.GetElement(fieldSelector));
        }
    }
}