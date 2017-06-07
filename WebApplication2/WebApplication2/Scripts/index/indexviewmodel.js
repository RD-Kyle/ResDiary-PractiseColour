rd.colours.indexviewmodel = function () {
    var self = this;

    self.colours = ko.observableArray([]);
    self.newColour = ko.observable("");


    var updateColoursArray = function (colours) {
        self.colours(ko.utils.arrayMap(colours.Colours, function (c) { return new rd.colours.colourviewmodel(c) }))
    }

    self.load = function () {
        rd.colours.service.getColours()
            .done(function (data) {
                updateColoursArray(data)
            })
            .fail(function (err) {
                var gdfgd =""
            })
    }

    self.addColour = function () {
        rd.colours.service.addColour(self.newColour())
            .done(function (data) {
                updateColoursArray(data)
            })
    }

    self.removeColour = function (colour) {
        rd.colours.service.removeColour(colour.id())
            .done(function (data) {
                updateColoursArray(data)
            })
    }

    self.cancelEdit = function (colour) {
        colour().setIsEdit(false);
    }

    self.saveColour = function (colour) {
        colour.unsetIsEdit()
        rd.colours.service.saveColour(colour)
            .done(function (data) {
                updateColoursArray(data)
            })
    }
}