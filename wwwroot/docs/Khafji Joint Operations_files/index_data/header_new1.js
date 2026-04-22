// JavaScript Document
function validateEmail(emailField){
        var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;

        if (reg.test(emailField) == false) 
        {
            return false;
        }

        return true;

}

function subscribeEmail()
{
	var email_val = document.getElementById("email").value;
	if(email_val.length < 1 )
	{
		alert("Please enter your E-Mail Address to Subscribe !!!");
	}
	else
	{
		var checkEmail = validateEmail(email_val);
		if(checkEmail == true)
		{
			window.open("/webdynpro/resources/demo.sap.com/addorraengadmin/Email?email-id="+email_val,"MyWindow","toolbar=no, menubar=no,scrollbars=no,resizable=no,location=no,directories=no,status=no,width=400, height=100");	
			//alert("Thank you for Subscribing !!!");
			document.getElementById("email").value = "";
		}
		else 
			alert("Invalid Email Address !!!");
	}
}


function fileReader(leftmenu)
{
	//alert("In Reader screen.width["+screen.width+"], screen.height["+screen.height+"]");
	// alert(location.pathname.substring(location.pathname.lastIndexOf("/")+1, location.pathname.lastIndexOf(".")));
	var txtFile = new XMLHttpRequest();
	txtFile.open("GET", "configdonotdelete1_new.txt", true);
	txtFile.onreadystatechange = function()
	{
		//alert("Found1");
	  if (txtFile.readyState === 4) {  //alert("Found2");// document is ready to parse.
		if (txtFile.status === 200) {  //alert("Found3");// file is found
		  allText = txtFile.responseText; 
		  //alert(allText);
		  lines = txtFile.responseText.split("\n");
		  //alert(lines.length);
		  for(var i=0; i<lines.length; i++)
		  {
			  //alert(lines[i]);
			  var line = lines[i].split('~');
			  if(line[0] == "HEADER")
			  {
				  //alert("Found Header");
				  document.getElementById("header").innerHTML = ""+line[1];
			  }
			  else if(line[0] == "FOOTER")
			  {
				  //alert("Found Footer");
				  document.getElementById("outer_footer").innerHTML = ""+line[1];
			  }
			  else if(line[0] == "OTHER_LINKS")
			  {
				  document.getElementById("other_links").innerHTML = ""+line[1];
			  }
			  else if(line[0] == leftmenu)
			  {
				//alert("adding left menu");
				document.getElementById("right_content").innerHTML = ""+line[1];
				//alert("adding left menu done");
			  }
			  /*else if(line[0] == "ORGANIZATION")
			  {
				//alert("adding left menu");
				document.getElementById("right_content").innerHTML = ""+line[1];
				//alert("adding left menu done");
			  }*/
		  }
		}
	  }
	}
	txtFile.send(null);
	
	trap();
}

function right(e)
{
	var msg = "";
	if ((navigator.appName == 'Netscape' && e.which == 3) || (navigator.appName == 'Microsoft Internet Explorer' && event.button==2)) 
	{
		//alert(msg);
		return false;
	}
	else return true;
 }
function trap() {
	if(document.images)
		for(i=0; i<document.images.length;i++)
			document.images[i].onmousedown = right;
 }
 
 function passVal() {
	 //alert("Lets Search");
	location.href = "SearchResult.html?&val=" + document.getElementById('txtInput').value;		
}