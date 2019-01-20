﻿using System;

namespace Reddit.Inputs.Flair
{
    [Serializable]
    public class FlairTemplateIdInput
    {
        /// <summary>
        /// a valid flair template ID
        /// </summary>
        public string flair_template_id { get; set; }
    }
}
