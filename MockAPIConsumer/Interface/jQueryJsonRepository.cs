using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockAPIConsumer.Interface
{
    public class jQueryJsonRepository
    {
        //This is not a repository, but a list of client-side scripts to run on the main page, in place of a repository called by the controller.

        //GET
        //<script>
        //$(function () {
        //  $.getJSON('myApiAddress'.done(function (data) {
        //    $.each(data, function (index, item) {
        //      for(prop in item) {
        //        $('#myDiv').append(prop + ' : ' + item[prop] + '<br />');
        //      }
        //    });
        //  });
        //});
        //</script


        //POST
        //<script>
        //var objToJson = $.parseJSON(item);
        //
        //$.each(objToJson), function () {
        //  myContent += this['myProp'] + '<br />';
        //});
        //$('myDiv').html(myContent);
        //
        //$.postJSON('myApiAddress', objToJson)
        //<script>


        //POST (using .ajax)
        //<script>
        //function () {
        //  var response = "";
        //  var myData = {~~~};
        //  $.ajax({
        //    type: 'POST', url: base_url + 'api/json', data: myData, dataType: 'json', success: function(response) {
        //      var jsonObj = $.parseJSON(response);
        //      for (var i in jsonObj) {
        //        var output += '<li>' + jsonObj[i].myProperty + '</li>';
        //      }
        //      $('myDiv').html(output);
        //    }
        //  });
        //}
        //</script>
    }
}