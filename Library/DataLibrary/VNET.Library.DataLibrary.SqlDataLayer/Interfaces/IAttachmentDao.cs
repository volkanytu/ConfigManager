﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VNET.Library.Entities.CrmEntities;

namespace VNET.Library.DataLibrary.SqlDataLayer.Interfaces
{
    public interface IAttachmentDao
    {
        List<Attachment> GetArticleAttachments(Guid articleId);
    }
}
