rd.colours.service = {
    getColours: function () {
        return $.get(rd.colours.constants.getColoursUrl)
    },
    addColour: function (colour) {
        return $.ajax({
            url: rd.colours.constants.addColourUrl,
            type: "POST",
            data: JSON.stringify({ Name: colour }),
            dataType: "json",
            contentType: "application/json"
        })
    },
    removeColour: function (colourId) {
        return $.ajax({
            url: rd.colours.constants.removeColourUrl,
            type: "POST",
            data: JSON.stringify({ Id: colourId }),
            dataType: "json",
            contentType: "application/json"
        })
    },
    saveColour: function (colour) {
        return $.ajax({
            url: rd.colours.constants.saveColourUrl,
            type: "POST",
            data: JSON.stringify({ Name: colour.name(), Id: colour.id()}),
            dataType: "json",
            contentType: "application/json"
        })
    }
}