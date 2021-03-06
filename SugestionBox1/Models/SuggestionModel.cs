﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SugestionBox1.Models
{
    public class SuggestionModel
    {
        private string topic;
        private string suggestion;

        [Key] //this refers only to the line immediately after it//
        public int RecordNum { get; set; }
        public string Name { get; set; }

        public string Topic
        {
            get { return this.topic; }
            set { this.topic = value; }
        }

       public string Suggestion
        {
            get { return this.suggestion; }
            set { this.suggestion = value; }
        }
    }

}