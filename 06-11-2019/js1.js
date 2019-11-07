		function validate()
		{
				var f1 = document.forms[0];
                var param1 = f1.param1;
                var param2 = f1.param2;
				var msg =f1.Strength;
		    	if(param1.value.length>5)
			{
					msg ="strong";
			}
			else
				msg="poor";

		    	document.getElementById("4").innerText = msg;

				if (param1.value == 0 ||param2.value==0 )
				{
					var param1 = document.getElementById("1");
					param1.style.color = "red";
					param1.innerHTML ="write something"; 
					var param2 = document.getElementById("2");
					param2.style.color = "red";
					param2.innerHTML ="write something"; 
					return false;
				}
				return true;
			}
			function check()
			{
				var f1 = document.forms[0];
                var p1 = f1.param1;
                var p2 = f1.param2;
              	if (p1.value != 0 )
				{
					var p1 = document.getElementById("1");
					p1.innerHTML =""; 
				}
             if(p2.value != 0)
					{
					var p2 = document.getElementById("2");
					p2.innerHTML =""; 
				}
			}
