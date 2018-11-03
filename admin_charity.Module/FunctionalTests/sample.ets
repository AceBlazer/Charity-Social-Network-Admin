;#DropDB admin_charityEasyTest

#Application admin_charity.Win
#Application admin_charity.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef admin_charity.Win

*Action About...
 
*Action OK

#EndIf

#IfDef admin_charity.Web

*Action Choose Theme(Black Glass)

#EndIf
