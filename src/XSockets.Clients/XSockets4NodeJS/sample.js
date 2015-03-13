﻿var xsockets = require('./xsockets.net');

var c = new xsockets.TcpClient('127.0.0.1', 4502, ['animal','car']);
c.controller('animal').on('cat', function(d) {
    console.log('cat',d.says);
});

c.controller('car').on('bmw', function (d) {
    console.log('bmw', d.says);
});

c.controller('animal').onopen = function(ci) {
    console.log('connected controller animal');    
    c.controller('animal').send('cat', {says:'mjau'});
}

c.controller('car').onopen = function (ci) {
    console.log('connected controller car');    
    c.controller('car').send('bmw', { says: 'wroom' });
}

c.onconnected = function(d) {
    console.log('connected', d);
}
c.open();