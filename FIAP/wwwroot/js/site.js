function HideMenus(param) {

    if (param) {
        $('#linkServico').show();
        $('#linkPublico').show()
        $('#linkPreco').show()
        $('#linkInformacao').show()
    } else {
        $('#linkServico').hide();
        $('#linkPublico').hide()
        $('#linkPreco').hide()
        $('#linkInformacao').hide()
        
    }
}

function showLogout(session) {

    if (session.length > 0) {
        $('#linkSair').show()
    }
    else {
        $('#linkSair').hide()
    }

}


