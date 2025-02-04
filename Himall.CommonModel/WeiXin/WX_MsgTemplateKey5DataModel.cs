﻿namespace Himall.CommonModel.WeiXin
{
    /// <summary>
    /// 微信模板信息模型
    /// <para>keyword请按顺序对应，如果无内容保持空</para>
    /// </summary>
    public class WX_MsgTemplateKey5DataModel
    {
        public WX_MsgTemplateKey5DataModel()
        {
            this.first = new WX_MSGItemBaseModel();
            this.keyword1 = new WX_MSGItemBaseModel();
            this.keyword2 = new WX_MSGItemBaseModel();
            this.keyword3 = new WX_MSGItemBaseModel();
            this.keyword4 = new WX_MSGItemBaseModel();
            this.keyword5 = new WX_MSGItemBaseModel();
            this.remark = new WX_MSGItemBaseModel();
        }
        public WX_MSGItemBaseModel first { get; set; }
        public WX_MSGItemBaseModel keyword1 { get; set; }
        public WX_MSGItemBaseModel keyword2 { get; set; }
        public WX_MSGItemBaseModel keyword3 { get; set; }
        public WX_MSGItemBaseModel keyword4 { get; set; }
        public WX_MSGItemBaseModel keyword5 { get; set; }
        public WX_MSGItemBaseModel remark { get; set; }
    }
}
