# FileProtector
A file protector for Asp.net website to secure confidential files.

<p>File Protector project is to secure <span style="background-color: #ffffff;">confidential </span> files in encrypted format to keep these files safe from downloading/surfing. We can secure any type of file using executable available in this repository. This works with asp.net web applications. This is under development for asp.net core website and not working for this version. To use this project to secure files a database connection is required as attached executable encrypts specified files and saves in database to protect.</p>
<p><strong>How to Use:</strong></p>
<p><strong>1: </strong>Create a sql server database with any name. We can use our application database to keep encrypted files.</p>
<p><strong>2:&nbsp;</strong>Extract <a id="50111028bbc61f195b5b459e07c52b7c-e0eac6a4a8eddff09464a3e22749acadbec30bf5" class="js-navigation-open " style="background-color: initial; box-sizing: border-box; color: #0366d6; font-family: -apple-system,BlinkMacSystemFont,Segoe UI,Helvetica,Arial,sans-serif,Apple Color Emoji,Segoe UI Emoji; font-size: 14px; font-style: normal; font-variant: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-decoration: none; text-indent: 0px; text-transform: none; -webkit-text-stroke-width: 0px; white-space: nowrap; word-spacing: 0px;" title="FileEncryptor.zip" href="https://github.com/ravisinghunnao/FileProtector/blob/master/FileEncryptor.zip">FileEncryptor.zip</a> and open <span style="background-color: #ffffff;">FilePathGenerator</span>.exe as below:<br /><img src="pathgen.jpg" alt="file path generator" width="300" /></p>
<p><strong>3:&nbsp;</strong>Browse the folder within website/webapplicaiton folder whose files need to be encrypted.</p>
<p><img src="browse.jpg" alt="select folder" width="300" /></p>
<p><strong>4:</strong> In extensions field, enter comma seperated file extensions to encrypt.</p>
<p><strong>5:</strong> Enter database connection string in connection string text box.</p>
<p><strong>6:</strong> Press generate button.</p>
<p>After pressing generate button, executable will encrypt all files for given extensions in specified folder. after encrypting files, application will display a message as given below:</p>
<p><img src="handlers.jpg" alt="handlers" width="300" /></p>
<p><strong>7:</strong> copy message and add handler values in web.config file as given below:</p>
<div><span style="background-color: #ffffff;">&lt;system.webServer&gt;<br />&nbsp;&nbsp;&nbsp; &lt;handlers&gt;</span></div>
<div><span style="background-color: #ffffff;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;add verb="*" path="*.htm" type="FileServer.Server, FileServer" name="htmHandler" /&gt;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;add verb="*" path="*.html" type="FileServer.Server, FileServer" name="htmlHandler" /&gt;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;add verb="*" path="*.css" type="FileServer.Server, FileServer" name="cssHandler" /&gt;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;add verb="*" path="*.js" type="FileServer.Server, FileServer" name="jsHandler" /&gt;<br />&nbsp;&nbsp;&nbsp; &lt;/handlers&gt;<br />&nbsp; &lt;/system.webServer&gt;</span></div>
<div>&nbsp;</div>
<div><strong><span style="background-color: #ffffff;">8:&nbsp;</span></strong><span style="background-color: #ffffff;">Add following settings in app settings section of web.config file.</span></div>
<div><span style="background-color: #ffffff;">&lt;appSettings&gt;<br />&nbsp;&nbsp;&nbsp; &lt;add key="FileServerConnectionString" value="ConnectionString for your database"/&gt;<br />&nbsp;&nbsp;&nbsp; &lt;add key="FileServerHeader" value="a secure header for your confidiential files"/&gt;<br />&nbsp;&nbsp;&nbsp; <br />&nbsp; &lt;/appSettings&gt;</span></div>
<div>&nbsp;</div>
<div><strong><span style="background-color: #ffffff;">9:&nbsp;</span></strong><span style="background-color: #ffffff;">After making these changes in your web application, Add reference to FileServer.dll available in repository.&nbsp;</span></div>
<div>&nbsp;</div>
<div><strong>10: </strong>Open global.aspx file and in application begin request add following code.</div>
<div>&nbsp;</div>
<div>
  <div><span style="background-color: #ffffff;">&nbsp; internal protected void Application_BeginRequest(object sender, EventArgs e)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Get objects.<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HttpContext context = base.Context;</span></div>
  <div><span style="background-color: #ffffff;">//header name is static, we can modify header value in both web.config and in begin request.</span></div>
  <div><span style="background-color: #ffffff;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; context.Request.Headers.Add("FileServerHeader", "<span style="background-color: #ffffff; color: #000000; font-family: Verdana,Arial,Helvetica,sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-decoration: none; text-indent: 0px; text-transform: none; -webkit-text-stroke-width: 0px; white-space: normal; word-spacing: 0px;">a secure header for your confidiential files</span>");<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Complete.<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</span></div>
  <div>&nbsp;</div>
  <div><span style="background-color: #ffffff;">That's all.</span></div>
  <div>&nbsp;</div>
  <div><span style="background-color: #ffffff;">Web application will work as usual but now you can validate if request is coming from valid user.&nbsp;</span></div>
</div>
