﻿namespace FloydPink.Flickr.Downloadr.UI.Widgets {
    using System.ComponentModel;
    using System.Web;
    using CachedImage;
    using Gtk;
    using Model;

    [ToolboxItem(true)]
    public partial class PreviewPhotoWidget : Bin {
        public PreviewPhotoWidget(Photo photo) {
            Build();
            labelCaption.LabelProp =
                string.Format("<span color=\"white\" bgcolor=\"black\"><big><b>      {0}      </b></big></span>",
                    HttpUtility.HtmlEncode(photo.Title));
            imagePreview.SetCachedImage(FileCache.FromUrl(photo.Medium500Url));
        }
    }
}
