namespace admin_charity.Module.Web {
    partial class admin_charityAspNetModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // admin_charityAspNetModule
            // 
            this.RequiredModuleTypes.Add(typeof(admin_charity.Module.admin_charityModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Chart.Web.ChartAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.HtmlPropertyEditor.Web.HtmlPropertyEditorAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Notifications.Web.NotificationsAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ScriptRecorder.Web.ScriptRecorderAspNetModule));
        }

        #endregion
    }
}