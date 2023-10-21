function fechar() {
  document.getElementById('modal').style.visibility = 'hidden';
  document.getElementById('esmaecer').style.visibility = 'hidden';
}
function abrir() {
  document.getElementById('modal').style.visibility = 'visible';
  document.getElementById('esmaecer').style.visibility = 'visible';
}

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

function showPreview(event){
  if(event.target.files.length > 0){
    var src = URL.createObjectURL(event.target.files[0]);
    var preview = document.getElementById("file-ip-1-preview");
    preview.src = src;
    preview.style.display = "block";
    document.getElementById("botaoRemover").style.display = "block";
    document.getElementById("preview-margin").style.margin = "-19rem 0 0";
  }
  function unshowPreview(){
    var preview = document.getElementById("file-ip-1-preview");
    preview.style.display = "none";
  }
}