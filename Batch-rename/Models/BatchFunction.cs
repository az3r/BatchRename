﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BatchRename.Shared;
using BatchRename.DataTypes;
using System.Runtime.Serialization;
using System.Windows;

namespace BatchRename.Models
{
    public class BatchFunction : EventNotifier, IEquatable<BatchFunction>
    {
        public BatchFunction() { }
        public virtual BatchPath GetPath(BatchPath path)
        {
            BatchPath clone = path.Clone();
            clone.FullName = Path.Combine(path.GetParent(), GetString(path.Name));
            return clone;
        }
        public virtual string GetString(string src) { return src; }
        public virtual BatchFunction Clone() { return new BatchFunction() { Name = this.Name, IsFavorite = this.IsFavorite }; }

        public bool Equals(BatchFunction other)
        {
            if (other == null) return false;
            if (Name == other.Name) return true;
            return false;
        }

        public string Name
        {
            get => mName;
            set
            {
                mName = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsFavorite
        {
            get => mFavorite;
            set
            {
                mFavorite = value;
                NotifyPropertyChanged();
            }
        }

        protected string mName = string.Empty;
        private bool mFavorite = false;
    }
}
