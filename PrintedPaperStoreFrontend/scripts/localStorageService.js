var localStorageService = {
    add: function(storageKey, item) {
        var cartItems = [];
        // geting from locas storage the key with naming storageKey
        var storageData = localStorage.getItem(storageKey);

        if (storageData != null) {
            //checking if there is key with that kind of naming and parse it
            cartItems = JSON.parse(storageData);
        }
        //if there isnt item with that value it will return index -1
        if (cartItems.indexOf(item) == -1) {
            cartItems.push(item);
        }

        //overwrite the value with the new value 
        localStorage.setItem(storageKey, JSON.stringify(cartItems));
    },
    remove: function(storageKey, item) {
        var storageData = localStorage.getItem(storageKey);

        if (storageData != null) {
            var cartItems = JSON.parse(storageData);
            //same as where in Linq
            cartItems = cartItems.filter(x => x != item);

            localStorage.setItem(storageKey, JSON.stringify(cartItems));
        }
    },
    getAll: function(storageKey) {
        var cartItems = [];

        var storageData = localStorage.getItem(storageKey);

        if (storageData != null) {
            cartItems = JSON.parse(storageData);
        }

        return cartItems;
    },
    exists: function(storageKey, item) {
        var exists = false;
        var storageData = localStorage.getItem(storageKey);

        if (storageData != null) {
            var cartItems = JSON.parse(storageData);

            if (cartItems.indexOf(item) != -1) {
                exists = true;
            }
        }

        return exists;
    },
    clear: function(storageKey) {
        localStorage.removeItem(storageKey);
    }
}