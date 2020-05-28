using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace CurrencyConverter.behaviour
{
    class EntryLengthValidatorBehavior : Behavior<Entry>
    {
        //System.Text.StringBuilder builder = new System.Text.StringBuilder("Mahesh Chand");
        public int MaxLength { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnEntryTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnEntryTextChanged;
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            //char dot = ',';
            
            var entry = (Entry)sender;
            
     

            // if Entry text is longer then valid length
            if (entry.Text.Length > this.MaxLength)
            {
                string entryText = entry.Text;
                entryText = entryText.Remove(entryText.Length - 1); // remove last char
               

                entry.Text = entryText;
            }
        }
    }
}