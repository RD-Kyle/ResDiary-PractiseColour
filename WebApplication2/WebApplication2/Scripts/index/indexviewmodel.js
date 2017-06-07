indexviewmodel = function () {
    var self = this;

    self.colours = ko.observableArray([]);

    self.load = function () {
        $.get("/Home/getcolours")
            .done(function (data) {
                self.colours(ko.utils.arrayMap(data.Colours, function (c) { return new colourviewmodel(c) }))
            })
            .fail(function (err) {
                var gdfgd =""
            })
    }
}