rd.colours.colourviewmodel = function (Colour) {
    var self = this;

    self.name = ko.observable(Colour.Name);
    self.id = ko.observable(Colour.Id);
    self.isEdit = ko.observable(false);

    self.setIsEdit = function () {
        self.isEdit(true);
    }

    self.unsetIsEdit = function () {
        self.isEdit(false);
    }
}