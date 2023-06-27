function abrir_plus() {
      if (document.getElementById('menu1').style.visibility == 'visible') {
        document.getElementById('menu1').style.visibility = 'hidden';
      }

      else {
        document.getElementById('menu1').style.visibility = 'visible';
        document.getElementById('menu2').style.visibility = 'hidden';
        document.getElementById('menu3').style.visibility = 'hidden';

      }

    }

    function abrir_perfil() {
      if (document.getElementById('menu2').style.visibility == 'visible') {
        document.getElementById('menu2').style.visibility = 'hidden';
      }

      else {
        document.getElementById('menu2').style.visibility = 'visible';
        document.getElementById('menu1').style.visibility = 'hidden';
        document.getElementById('menu3').style.visibility = 'hidden';
      }

    }

    function abrir_notif() {
      if (document.getElementById('menu3').style.visibility == 'visible') {
        document.getElementById('menu3').style.visibility = 'hidden';
      }

      else {
        document.getElementById('menu3').style.visibility = 'visible';
        document.getElementById('menu1').style.visibility = 'hidden';
        document.getElementById('menu2').style.visibility = 'hidden';
      }

    }