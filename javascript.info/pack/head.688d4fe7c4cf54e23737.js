var head = function(t) {
function e(n) {
if (r[n]) return r[n].exports;
var o = r[n] = {
i: n,
l: !1,
exports: {}
};
return t[n].call(o.exports, o, o.exports, e), o.l = !0, o.exports;
}
var n = window.webpackJsonp_name_;
window.webpackJsonp_name_ = function(r, i, c) {
for (var a, s, u, l = 0, f = []; l < r.length; l++) s = r[l], o[s] && f.push(o[s][0]), 
o[s] = 0;
for (a in i) Object.prototype.hasOwnProperty.call(i, a) && (t[a] = i[a]);
for (n && n(r, i, c); f.length; ) f.shift()();
if (c) for (l = 0; l < c.length; l++) u = e(e.s = c[l]);
return u;
};
var r = {}, o = {
14: 0
};
return e.e = function(t) {
function n() {
a.onerror = a.onload = null, clearTimeout(s);
var e = o[t];
0 !== e && (e && e[1](Error("Loading chunk " + t + " failed.")), o[t] = void 0);
}
var r = o[t];
if (0 === r) return new Promise(function(t) {
t();
});
if (r) return r[2];
var i = new Promise(function(e, n) {
r = o[t] = [ e, n ];
});
r[2] = i;
var c = document.getElementsByTagName("head")[0], a = document.createElement("script");
a.type = "text/javascript", a.charset = "utf-8", a.async = !0, a.timeout = 12e4, 
e.nc && a.setAttribute("nonce", e.nc), a.src = e.p + "" + ({
"0": "search",
"1": "coursesCourse",
"2": "authClient",
"3": "footer",
"4": "angular",
"5": "tutorial",
"6": "ebookExtras",
"7": "coursesSignup",
"8": "ebook",
"10": "profile",
"11": "coursesParticipantDetails",
"12": "about",
"13": "quiz",
"16": "coursesMaterials",
"17": "auth",
"18": "coursesFrontpage",
"19": "coursesFeedbackEdit",
"20": "coursesFeedbackList",
"21": "coursesFeedbackShow",
"22": "profileGuestAboutMe",
"24": "donate",
"25": "newsletterAdmin",
"27": "qa",
"28": "screencast",
"29": "styles",
"30": "markup",
"31": "coursesGroupInfo"
}[t] || t) + "-" + t + ".688d4fe7c4cf54e23737.js";
var s = setTimeout(n, 12e4);
return a.onerror = a.onload = n, c.appendChild(a), i;
}, e.m = t, e.c = r, e.d = function(t, n, r) {
e.o(t, n) || Object.defineProperty(t, n, {
configurable: !1,
enumerable: !0,
get: r
});
}, e.n = function(t) {
var n = t && t.__esModule ? function() {
return t.default;
} : function() {
return t;
};
return e.d(n, "a", n), n;
}, e.o = function(t, e) {
return Object.prototype.hasOwnProperty.call(t, e);
}, e.p = "/pack/", e.oe = function(t) {
throw t;
}, e(e.s = 17);
}({
1: function(t, e, n) {
function r(t) {
return n(o(t));
}
function o(t) {
var e = i[t];
if (!(e + 1)) throw Error("Cannot find module '" + t + "'.");
return e;
}
var i = {
"./en.yml": 672,
"./ru.yml": 673
};
r.keys = function() {
return Object.keys(i);
}, r.resolve = o, t.exports = r, r.id = 1;
},
17: function(t, e, n) {
"use strict";
n(563), e.login = n(683), n(684), e.Modal = n(529), e.resizeOnload = n(571), n(576), 
n(577), n(578), n(579), n(581), n(582), n(523).init(), e.showTopNotification = function() {
var t = document.querySelector(".notification_top"), e = t.id;
if (t.querySelector("button").onclick = function() {
localStorage.topNotificationHidden = e, t.style.display = "none", window.dispatchEvent(new CustomEvent("resize-internal"));
}, !e) throw Error("Top notification must have an id");
localStorage.topNotificationHidden != e && (delete localStorage.topNotificationHidden, 
t.style.display = "");
};
},
523: function(t, e, n) {
"use strict";
function r(t, e) {
if (!t) throw new ReferenceError("this hasn't been initialised - super() hasn't been called");
return !e || "object" != typeof e && "function" != typeof e ? t : e;
}
function o(t, e) {
if ("function" != typeof e && null !== e) throw new TypeError("Super expression must either be null or a function, not " + typeof e);
t.prototype = Object.create(e && e.prototype, {
constructor: {
value: t,
enumerable: !1,
writable: !0,
configurable: !0
}
}), e && (Object.setPrototypeOf ? Object.setPrototypeOf(t, e) : t.__proto__ = e);
}
function i(t, e) {
if (!(t instanceof e)) throw new TypeError("Cannot call a class as a function");
}
Object.defineProperty(e, "__esModule", {
value: !0
});
var c, a = function() {
function t(t, e) {
for (var n = 0; n < e.length; n++) {
var r = e[n];
r.enumerable = r.enumerable || !1, r.configurable = !0, "value" in r && (r.writable = !0), 
Object.defineProperty(t, r.key, r);
}
}
return function(e, n, r) {
return n && t(e.prototype, n), r && t(e, r), e;
};
}(), s = n(524), u = function() {
function t() {
var e = arguments.length > 0 && void 0 !== arguments[0] ? arguments[0] : {};
i(this, t), this.notifications = [], this.verticalSpace = e.verticalSpace || 8;
}
return a(t, [ {
key: "register",
value: function(t) {
var e = this;
this.notifications.unshift(t), setTimeout(function() {
return e.recalculate();
}, 20);
}
}, {
key: "unregister",
value: function(t) {
var e = this.notifications.indexOf(t);
this.notifications.splice(e, 1), this.recalculate();
}
}, {
key: "recalculate",
value: function() {
var t = this, e = this.verticalSpace;
this.notifications.forEach(function(n) {
n.top = e, e += n.height + t.verticalSpace;
});
}
} ]), t;
}();
e.init = function(t) {
c = new u(t);
};
var l = function() {
function t(e, n, r) {
i(this, t);
var o = '<div class="notification notification_popup notification_' + n + '">\n    <div class="notification__content">' + e + '</div>\n    <button title="Закрыть" class="notification__close"></button></div>';
switch (document.body.insertAdjacentHTML("beforeEnd", o), this.elem = document.body.lastElementChild, 
r) {
case void 0:
this.timeout = this.TIMEOUT_DEFAULT;
break;

case "slow":
this.timeout = this.TIMEOUT_SLOW;
break;

case "fast":
this.timeout = this.TIMEOUT_FAST;
break;

default:
this.timeout = r;
}
c.register(this), this.setupCloseHandler(), this.setupCloseTimeout();
}
return a(t, [ {
key: "close",
value: function() {
this.elem.parentNode && (this.elem.remove(), c.unregister(this));
}
}, {
key: "setupCloseHandler",
value: function() {
var t = this;
this.delegate(".notification__close", "click", function() {
return t.close();
});
}
}, {
key: "setupCloseTimeout",
value: function() {
var t = this;
this.timeout && setTimeout(function() {
return t.close();
}, this.timeout);
}
}, {
key: "TIMEOUT_DEFAULT",
get: function() {
return 2500;
}
}, {
key: "TIMEOUT_SLOW",
get: function() {
return 5e3;
}
}, {
key: "TIMEOUT_FAST",
get: function() {
return 1500;
}
}, {
key: "height",
get: function() {
return this.elem.offsetHeight;
}
}, {
key: "top",
set: function(t) {
this.elem.style.transform = "translateY(" + t + "px)";
}
} ]), t;
}();
s.delegateMixin(l.prototype);
var f = function(t) {
function e(t, n) {
return i(this, e), r(this, (e.__proto__ || Object.getPrototypeOf(e)).call(this, t, "info", n));
}
return o(e, t), e;
}(l);
e.Info = f;
var d = function(t) {
function e(t, n) {
return i(this, e), r(this, (e.__proto__ || Object.getPrototypeOf(e)).call(this, t, "warning", n));
}
return o(e, t), e;
}(l);
e.Warning = d;
var h = function(t) {
function e(t, n) {
return i(this, e), r(this, (e.__proto__ || Object.getPrototypeOf(e)).call(this, t, "success", n));
}
return o(e, t), e;
}(l);
e.Success = h;
var p = e.Error = function(t) {
function e(t, n) {
return i(this, e), r(this, (e.__proto__ || Object.getPrototypeOf(e)).call(this, t, "error", n));
}
return o(e, t), a(e, [ {
key: "TIMEOUT_DEFAULT",
get: function() {
return 5e3;
}
} ]), e;
}(l);
e.Error = p;
},
524: function(t, e, n) {
"use strict";
function r(t, e) {
for (var n = t.target; n; ) {
if (n.matches(e)) return n;
if (n == t.currentTarget) break;
n = n.parentElement;
}
return null;
}
function o(t, e, n, o, i) {
t.addEventListener(n, function(t) {
var n = r(t, e);
t.delegateTarget = n, n && o.call(i || this, t);
});
}
o.delegateMixin = function(t) {
t.delegate = function(t, e, n) {
o(this.elem, t, e, n, this);
};
}, t.exports = o;
},
526: function(t, e, n) {
"use strict";
function r(t) {
if (t = t || {}, this.elem = t.elem, this.size = t.size || "medium", this.class = t.class ? " " + t.class : "", 
this.elemClass = t.elemClass, "medium" != this.size && "small" != this.size && "large" != this.size) throw Error("Unsupported size: " + this.size);
this.elem || (this.elem = document.createElement("div"));
}
r.prototype.start = function() {
this.elemClass && this.elem.classList.toggle(this.elemClass), this.elem.insertAdjacentHTML("beforeend", '<span class="spinner spinner_active spinner_' + this.size + this.class + '"><span class="spinner__dot spinner__dot_1"></span><span class="spinner__dot spinner__dot_2"></span><span class="spinner__dot spinner__dot_3"></span></span>');
}, r.prototype.stop = function() {
var t = this.elem.querySelector(".spinner");
t && (t.remove(), this.elemClass && this.elem.classList.toggle(this.elemClass));
}, t.exports = r;
},
529: function(t, e, n) {
"use strict";
function r(t) {
t = t || {}, this.render(), this.setHasClose(void 0 === t.hasClose || t.hasClose), 
this.onClick = this.onClick.bind(this), this.onDocumentKeyDown = this.onDocumentKeyDown.bind(this), 
this.elem.addEventListener("click", this.onClick), document.addEventListener("keydown", this.onDocumentKeyDown);
}
var o = n(538), i = n(537).lang;
o.requirePhrase("site", n(1)("./" + i + ".yml")), r.prototype.setHasClose = function(t) {
this._hasClose = t, this._hasClose ? this.elem.classList.add("modal__has-close") : this.elem.classList.remove("modal__has-close");
}, r.prototype.render = function() {
document.body.insertAdjacentHTML("beforeEnd", '<div class="modal"><div class="modal__dialog"><button class="close-button modal__close" title="' + o("site.close") + '"></button><div class="modal__content"></div></div></div>'), 
document.body.classList.add("paranja-open"), this.elem = document.body.lastChild, 
this.contentElem = this.elem.querySelector(".modal__content");
}, r.prototype.onClick = function(t) {
t.target.classList.contains("modal__close") && (this.remove(), t.preventDefault());
}, r.prototype.onDocumentKeyDown = function(t) {
27 == t.keyCode && (t.preventDefault(), this.remove());
}, r.prototype.showOverlay = function() {
this.contentElem.classList.add("modal-overlay_light");
}, r.prototype.hideOverlay = function() {
this.contentElem.classList.remove("modal-overlay_light");
}, r.prototype.setContent = function(t) {
"string" == typeof t ? this.contentElem.innerHTML = t : (this.contentElem.innerHTML = "", 
this.contentElem.appendChild(t));
var e = this.contentElem.querySelector("[data-modal-autofocus],[autofocus]");
e && e.focus();
}, r.prototype.remove = function() {
document.body.classList.remove("paranja-open"), document.body.removeChild(this.elem), 
document.removeEventListener("keydown", this.onDocumentKeyDown), this.elem.dispatchEvent(new CustomEvent("modal-remove"));
}, t.exports = r;
},
537: function(t, e, n) {
"use strict";
t.exports = {
lang: "en",
ordersMail: "orders@javascript.info",
providers: [ {
name: "Facebook",
id: "facebook"
}, {
name: "Google+",
id: "google"
}, {
name: "Github",
id: "github"
} ]
};
},
538: function(t, e, n) {
"use strict";
function r() {
for (var t = [ c ], e = 0; e < arguments.length; e++) t.push(arguments[e]);
return i.t.apply(i, t);
}
var o = n(539), i = new o("en"), c = n(537).lang, a = {};
r.i18n = i, r.requirePhrase = function(t, e) {
a[t] && -1 != a[t].indexOf(e) || (a[t] || (a[t] = []), a[t].push(e), i.addPhrase(c, t, e));
}, t.exports = r;
},
539: function(t, e, n) {
"use strict";
t.exports = n(540);
},
540: function(t, e, n) {
"use strict";
function r(t) {
return Object.prototype.toString.call(t);
}
function o(t) {
return "[object String]" === r(t);
}
function i(t) {
return !isNaN(t) && isFinite(t);
}
function c(t) {
return !0 === t || !1 === t;
}
function a(t) {
return "[object Function]" === r(t);
}
function s(t) {
return "[object Object]" === r(t);
}
function u(t, e, n) {
if (null !== t) if (w && t.forEach === w) t.forEach(e, n); else if (t.length === +t.length) for (var r = 0, o = t.length; r < o; r += 1) e.call(n, t[r], r, t); else for (var i in t) Object.prototype.hasOwnProperty.call(t, i) && e.call(n, t[i], i, t);
}
function l(t) {
var e = 1, n = arguments, r = n.length;
return (t + "").replace(E, function(t) {
if ("%%" === t) return "%";
if (e >= r) return t;
switch (t) {
case "%s":
return n[e++] + "";

case "%d":
return +n[e++];

case "%j":
return JSON.stringify(n[e++]);

default:
return t;
}
});
}
function f(t) {
var e = {};
return u(t || {}, function(t, n) {
if (t && "object" === (void 0 === t ? "undefined" : y(t))) return void u(f(t), function(t, r) {
e[n + "." + r] = t;
});
e[n] = t;
}), e;
}
function d(t, e) {
return t + x + e;
}
function h(t, e, n) {
var r = d(e, n), o = t._storage;
if (o.hasOwnProperty(r)) return r;
if (e === t._defaultLocale) return null;
var i = t._fallbacks_cache;
if (i.hasOwnProperty(r)) return i[r];
for (var c, a = t._fallbacks[e] || [ t._defaultLocale ], s = 0, u = a.length; s < u; s++) if (c = d(a[s], n), 
o.hasOwnProperty(c)) return i[r] = c, i[r];
return i[r] = null, null;
}
function p(t, e, n) {
var r = b.indexOf(t, e);
return -1 === r ? l('[pluralizer for "%s" locale not found]', t) : void 0 === n[r] ? l('[plural form %d ("%s") not found in translation]', r, b.forms(t)[r]) : n[r];
}
function m(t) {
if (!(this instanceof m)) return new m(t);
this._defaultLocale = t ? t + "" : k, this._fallbacks = {}, this._fallbacks_cache = {}, 
this._storage = {}, this._plurals_cache = {};
}
function v(t, e, n) {
var r, o, i, c, a, s;
return F.test(e) ? (r = g.parse(e), 1 === r.length && "literal" === r[0].type ? r[0].text : (t._plurals_cache[n] || (t._plurals_cache[n] = new m(n)), 
s = t._plurals_cache[n], o = [], o.push([ 'var str = "", strict, strict_exec, forms, forms_exec, plrl, cache, loc, loc_plzr, anchor;' ]), 
o.push("params = flatten(params);"), u(r, function(t) {
if ("literal" === t.type) return void o.push(l("str += %j;", t.text));
if ("variable" === t.type) return i = t.anchor, void o.push(l('str += ("undefined" === typeof (params[%j])) ? "[missed variable: %s]" : params[%j];', i, i, i));
if ("plural" !== t.type) throw Error("Unknown node type");
i = t.anchor, c = {}, u(t.strict, function(e, r) {
var o = g.parse(e);
if (1 === o.length && "literal" === o[0].type) return c[r] = !1, void (t.strict[r] = o[0].text);
c[r] = !0, s.hasPhrase(n, e, !0) || s.addPhrase(n, e, e);
}), a = {}, u(t.forms, function(e, r) {
var o, i = g.parse(e);
if (1 === i.length && "literal" === i[0].type) return o = i[0].text, t.forms[r] = o, 
void (a[o] = !1);
a[e] = !0, s.hasPhrase(n, e, !0) || s.addPhrase(n, e, e);
}), o.push(l("loc = %j;", n)), o.push(l("loc_plzr = %j;", n.split(/[-_]/)[0])), 
o.push(l("anchor = params[%j];", i)), o.push(l("cache = this._plurals_cache[loc];")), 
o.push(l("strict = %j;", t.strict)), o.push(l("strict_exec = %j;", c)), o.push(l("forms = %j;", t.forms)), 
o.push(l("forms_exec = %j;", a)), o.push("if (+(anchor) != anchor) {"), o.push(l('  str += "[invalid plurals amount: %s(" + anchor + ")]";', i)), 
o.push("} else {"), o.push("  if (strict[anchor] !== undefined) {"), o.push("    plrl = strict[anchor];"), 
o.push("    str += strict_exec[anchor] ? cache.t(loc, plrl, params) : plrl;"), o.push("  } else {"), 
o.push("    plrl = pluralizer(loc_plzr, +anchor, forms);"), o.push("    str += forms_exec[plrl] ? cache.t(loc, plrl, params) : plrl;"), 
o.push("  }"), o.push("}");
}), o.push("return str;"), Function("params", "flatten", "pluralizer", o.join("\n")))) : e;
}
var y = "function" == typeof Symbol && "symbol" == typeof Symbol.iterator ? function(t) {
return typeof t;
} : function(t) {
return t && "function" == typeof Symbol && t.constructor === Symbol && t !== Symbol.prototype ? "symbol" : typeof t;
}, g = n(541), b = n(542), _ = Array.isArray || function(t) {
return "[object Array]" === r(t);
}, w = Array.prototype.forEach, E = /%[sdj%]/g, k = "en", x = "#@$";
m.prototype.addPhrase = function(t, e, n, r) {
var a, l = this;
if (c(r)) a = r ? 1 / 0 : 0; else if (i(r)) {
if ((a = Math.floor(r)) < 0) throw new TypeError("Invalid flatten level (should be >= 0).");
} else a = 1 / 0;
if (s(n) && a > 0) return u(n, function(n, r) {
l.addPhrase(t, (e ? e + "." : "") + r, n, a - 1);
}), this;
if (o(n)) this._storage[d(t, e)] = {
translation: n,
locale: t,
raw: !1
}; else {
if (!(_(n) || i(n) || c(n) || 0 === a && s(n))) throw new TypeError("Invalid translation - [String|Object|Array|Number|Boolean] expected.");
this._storage[d(t, e)] = {
translation: n,
locale: t,
raw: !0
};
}
return l._fallbacks_cache = {}, this;
}, m.prototype.setFallback = function(t, e) {
var n = this._defaultLocale;
if (n === t) throw Error("Default locale can't have fallbacks");
var r = _(e) ? e.slice() : [ e ];
return r[r.length - 1] !== n && r.push(n), this._fallbacks[t] = r, this._fallbacks_cache = {}, 
this;
};
var F = /#\{|\(\(|\\\\/;
m.prototype.translate = function(t, e, n) {
var r, c = h(this, t, e);
return c ? (r = this._storage[c], r.raw ? r.translation : (r.hasOwnProperty("compiled") || (r.compiled = v(this, r.translation, r.locale)), 
a(r.compiled) ? ((i(n) || o(n)) && (n = {
count: n,
value: n
}), r.compiled.call(this, n, f, p)) : r.compiled)) : t + ": No translation for [" + e + "]";
}, m.prototype.hasPhrase = function(t, e, n) {
return n ? this._storage.hasOwnProperty(d(t, e)) : !!h(this, t, e);
}, m.prototype.getLocale = function(t, e, n) {
if (n) return this._storage.hasOwnProperty(d(t, e)) ? t : null;
var r = h(this, t, e);
return r ? r.split(x, 2)[0] : null;
}, m.prototype.t = m.prototype.translate, m.prototype.stringify = function(t) {
var e = this, n = {};
u(this._storage, function(t, e) {
n[e.split(x)[1]] = !0;
});
var r = {};
u(n, function(n, o) {
var i = h(e, t, o);
if (i) {
var c = e._storage[i].locale;
r[c] || (r[c] = {}), r[c][o] = e._storage[i].translation;
}
});
var o = {
fallback: {},
locales: r
}, i = (e._fallbacks[t] || []).slice(0, -1);
return i.length && (o.fallback[t] = i), JSON.stringify(o);
}, m.prototype.load = function(t) {
var e = this;
return o(t) && (t = JSON.parse(t)), u(t.locales, function(t, n) {
u(t, function(t, r) {
e.addPhrase(n, r, t, 0);
});
}), u(t.fallback, function(t, n) {
e.setFallback(n, t);
}), this;
}, t.exports = m;
},
541: function(t, e, n) {
"use strict";
t.exports = function() {
function t(t, e, n, r, o, i) {
this.message = t, this.expected = e, this.found = n, this.offset = r, this.line = o, 
this.column = i, this.name = "SyntaxError";
}
function e(e) {
function n() {
return e.substring(yt, vt);
}
function r(t) {
return gt !== t && (gt > t && (gt = 0, bt = {
line: 1,
column: 1,
seenCR: !1
}), function(t, n, r) {
var o, i;
for (o = n; o < r; o++) i = e.charAt(o), "\n" === i ? (t.seenCR || t.line++, t.column = 1, 
t.seenCR = !1) : "\r" === i || "\u2028" === i || "\u2029" === i ? (t.line++, t.column = 1, 
t.seenCR = !0) : (t.column++, t.seenCR = !1);
}(bt, gt, t), gt = t), bt;
}
function o(t) {
vt < _t || (vt > _t && (_t = vt, wt = []), wt.push(t));
}
function i(n, o, i) {
var c = r(i), a = i < e.length ? e.charAt(i) : null;
return null !== o && function(t) {
var e = 1;
for (t.sort(function(t, e) {
return t.description < e.description ? -1 : t.description > e.description ? 1 : 0;
}); e < t.length; ) t[e - 1] === t[e] ? t.splice(e, 1) : e++;
}(o), new t(null !== n ? n : function(t, e) {
var n, r, o, i = Array(t.length);
for (o = 0; o < t.length; o++) i[o] = t[o].description;
return n = t.length > 1 ? i.slice(0, -1).join(", ") + " or " + i[t.length - 1] : i[0], 
r = e ? '"' + function(t) {
function e(t) {
return t.charCodeAt(0).toString(16).toUpperCase();
}
return t.replace(/\\/g, "\\\\").replace(/"/g, '\\"').replace(/\x08/g, "\\b").replace(/\t/g, "\\t").replace(/\n/g, "\\n").replace(/\f/g, "\\f").replace(/\r/g, "\\r").replace(/[\x00-\x07\x0B\x0E\x0F]/g, function(t) {
return "\\x0" + e(t);
}).replace(/[\x10-\x1F\x80-\xFF]/g, function(t) {
return "\\x" + e(t);
}).replace(/[\u0180-\u0FFF]/g, function(t) {
return "\\u0" + e(t);
}).replace(/[\u1080-\uFFFF]/g, function(t) {
return "\\u" + e(t);
});
}(e) + '"' : "end of input", "Expected " + n + " but " + r + " found.";
}(o, a), o, a, i, c.line, c.column);
}
function c() {
var t, e;
for (t = [], e = m(), e === w && (e = a()) === w && (e = d()); e !== w; ) t.push(e), 
(e = m()) === w && (e = a()) === w && (e = d());
return t;
}
function a() {
var t, n, r, i, c;
return t = vt, e.substr(vt, 2) === F ? (n = F, vt += 2) : (n = w, 0 === Et && o(S)), 
n !== w ? (r = s(), r !== w ? (e.substr(vt, 2) === C ? (i = C, vt += 2) : (i = w, 
0 === Et && o(L)), i !== w ? (c = f(), c === w && (c = A), c !== w ? (yt = t, n = j(r, c), 
t = n) : (vt = t, t = x)) : (vt = t, t = x)) : (vt = t, t = x)) : (vt = t, t = x), 
t;
}
function s() {
var t, n, r, i;
return t = vt, n = u(), n !== w ? (124 === e.charCodeAt(vt) ? (r = O, vt++) : (r = w, 
0 === Et && o(T)), r !== w ? (i = s(), i !== w ? (yt = t, n = q(n, i), t = n) : (vt = t, 
t = x)) : (vt = t, t = x)) : (vt = t, t = x), t === w && (t = vt, n = u(), n !== w && (yt = t, 
n = P(n)), t = n), t;
}
function u() {
var t, n, r, i, c, a;
if (t = vt, 61 === e.charCodeAt(vt) ? (n = D, vt++) : (n = w, 0 === Et && o(z)), 
n !== w) {
if (r = [], M.test(e.charAt(vt)) ? (i = e.charAt(vt), vt++) : (i = w, 0 === Et && o(N)), 
i !== w) for (;i !== w; ) r.push(i), M.test(e.charAt(vt)) ? (i = e.charAt(vt), vt++) : (i = w, 
0 === Et && o(N)); else r = x;
if (r !== w) if (32 === e.charCodeAt(vt) ? (i = H, vt++) : (i = w, 0 === Et && o(R)), 
i === w && (i = A), i !== w) {
if (c = [], (a = l()) !== w) for (;a !== w; ) c.push(a), a = l(); else c = x;
c !== w ? (yt = t, n = I(r, c), t = n) : (vt = t, t = x);
} else vt = t, t = x; else vt = t, t = x;
} else vt = t, t = x;
if (t === w) {
if (t = vt, n = [], (r = l()) !== w) for (;r !== w; ) n.push(r), r = l(); else n = x;
n !== w && (yt = t, n = W()), t = n;
}
return t;
}
function l() {
var t, n, r;
return t = vt, 92 === e.charCodeAt(vt) ? (n = U, vt++) : (n = w, 0 === Et && o(B)), 
n !== w ? (K.test(e.charAt(vt)) ? (r = e.charAt(vt), vt++) : (r = w, 0 === Et && o($)), 
r !== w ? (yt = t, n = J(r), t = n) : (vt = t, t = x)) : (vt = t, t = x), t === w && (t = vt, 
n = vt, Et++, 124 === e.charCodeAt(vt) ? (r = O, vt++) : (r = w, 0 === Et && o(T)), 
r === w && (e.substr(vt, 2) === C ? (r = C, vt += 2) : (r = w, 0 === Et && o(L))), 
Et--, r === w ? n = G : (vt = n, n = x), n !== w ? (e.length > vt ? (r = e.charAt(vt), 
vt++) : (r = w, 0 === Et && o(Z)), r !== w ? (yt = t, n = X(), t = n) : (vt = t, 
t = x)) : (vt = t, t = x)), t;
}
function f() {
var t, n, r;
return t = vt, 58 === e.charCodeAt(vt) ? (n = Y, vt++) : (n = w, 0 === Et && o(Q)), 
n !== w ? (r = h(), r !== w ? (yt = t, n = V(r), t = n) : (vt = t, t = x)) : (vt = t, 
t = x), t;
}
function d() {
var t, n, r, i;
return t = vt, e.substr(vt, 2) === tt ? (n = tt, vt += 2) : (n = w, 0 === Et && o(et)), 
n !== w ? (r = h(), r !== w ? (125 === e.charCodeAt(vt) ? (i = nt, vt++) : (i = w, 
0 === Et && o(rt)), i !== w ? (yt = t, n = ot(r), t = n) : (vt = t, t = x)) : (vt = t, 
t = x)) : (vt = t, t = x), t;
}
function h() {
var t, n, r, i, c;
if (t = vt, (n = p()) !== w) if (46 === e.charCodeAt(vt) ? (r = it, vt++) : (r = w, 
0 === Et && o(ct)), r !== w) {
if (i = [], (c = h()) !== w) for (;c !== w; ) i.push(c), c = h(); else i = x;
i !== w ? (yt = t, n = at(), t = n) : (vt = t, t = x);
} else vt = t, t = x; else vt = t, t = x;
return t === w && (t = p()), t;
}
function p() {
var t, n, r, i;
if (t = vt, st.test(e.charAt(vt)) ? (n = e.charAt(vt), vt++) : (n = w, 0 === Et && o(ut)), 
n !== w) {
for (r = [], lt.test(e.charAt(vt)) ? (i = e.charAt(vt), vt++) : (i = w, 0 === Et && o(ft)); i !== w; ) r.push(i), 
lt.test(e.charAt(vt)) ? (i = e.charAt(vt), vt++) : (i = w, 0 === Et && o(ft));
r !== w ? (yt = t, n = X(), t = n) : (vt = t, t = x);
} else vt = t, t = x;
return t;
}
function m() {
var t, e, n, r, o;
if (t = vt, e = [], n = vt, r = vt, Et++, o = a(), o === w && (o = d()), Et--, o === w ? r = G : (vt = r, 
r = x), r !== w ? (o = v(), o !== w ? (yt = n, r = dt(o), n = r) : (vt = n, n = x)) : (vt = n, 
n = x), n !== w) for (;n !== w; ) e.push(n), n = vt, r = vt, Et++, o = a(), o === w && (o = d()), 
Et--, o === w ? r = G : (vt = r, r = x), r !== w ? (o = v(), o !== w ? (yt = n, 
r = dt(o), n = r) : (vt = n, n = x)) : (vt = n, n = x); else e = x;
return e !== w && (yt = t, e = ht(e)), t = e;
}
function v() {
var t, n, r;
return t = vt, 92 === e.charCodeAt(vt) ? (n = U, vt++) : (n = w, 0 === Et && o(B)), 
n !== w ? (pt.test(e.charAt(vt)) ? (r = e.charAt(vt), vt++) : (r = w, 0 === Et && o(mt)), 
r !== w ? (yt = t, n = J(r), t = n) : (vt = t, t = x)) : (vt = t, t = x), t === w && (e.length > vt ? (t = e.charAt(vt), 
vt++) : (t = w, 0 === Et && o(Z))), t;
}
function y(t) {
for (var e = [], n = 0; n < t.length; n++) void 0 === t[n].strict && e.push(t[n].text);
return e;
}
function g(t) {
for (var e = {}, n = 0; n < t.length; n++) void 0 !== t[n].strict && (e[t[n].strict] = t[n].text);
return e;
}
var b, _ = arguments.length > 1 ? arguments[1] : {}, w = {}, E = {
start: c
}, k = c, x = w, F = "((", S = {
type: "literal",
value: "((",
description: '"(("'
}, C = "))", L = {
type: "literal",
value: "))",
description: '"))"'
}, A = null, j = function(t, e) {
return {
type: "plural",
forms: y(t),
strict: g(t),
anchor: e || "count"
};
}, O = "|", T = {
type: "literal",
value: "|",
description: '"|"'
}, q = function(t, e) {
return [ t ].concat(e);
}, P = function(t) {
return [ t ];
}, D = "=", z = {
type: "literal",
value: "=",
description: '"="'
}, M = /^[0-9]/, N = {
type: "class",
value: "[0-9]",
description: "[0-9]"
}, H = " ", R = {
type: "literal",
value: " ",
description: '" "'
}, I = function(t, e) {
return {
strict: t.join(""),
text: e.join("")
};
}, W = function() {
return {
text: n()
};
}, U = "\\", B = {
type: "literal",
value: "\\",
description: '"\\\\"'
}, K = /^[\\|)(]/, $ = {
type: "class",
value: "[\\\\|)(]",
description: "[\\\\|)(]"
}, J = function(t) {
return t;
}, G = void 0, Z = {
type: "any",
description: "any character"
}, X = function() {
return n();
}, Y = ":", Q = {
type: "literal",
value: ":",
description: '":"'
}, V = function(t) {
return t;
}, tt = "#{", et = {
type: "literal",
value: "#{",
description: '"#{"'
}, nt = "}", rt = {
type: "literal",
value: "}",
description: '"}"'
}, ot = function(t) {
return {
type: "variable",
anchor: t
};
}, it = ".", ct = {
type: "literal",
value: ".",
description: '"."'
}, at = function() {
return n();
}, st = /^[a-zA-Z_$]/, ut = {
type: "class",
value: "[a-zA-Z_$]",
description: "[a-zA-Z_$]"
}, lt = /^[a-zA-Z0-9_$]/, ft = {
type: "class",
value: "[a-zA-Z0-9_$]",
description: "[a-zA-Z0-9_$]"
}, dt = function(t) {
return t;
}, ht = function(t) {
return {
type: "literal",
text: t.join("")
};
}, pt = /^[\\#()|]/, mt = {
type: "class",
value: "[\\\\#()|]",
description: "[\\\\#()|]"
}, vt = 0, yt = 0, gt = 0, bt = {
line: 1,
column: 1,
seenCR: !1
}, _t = 0, wt = [], Et = 0;
if ("startRule" in _) {
if (!(_.startRule in E)) throw Error("Can't start parsing from rule \"" + _.startRule + '".');
k = E[_.startRule];
}
if ((b = k()) !== w && vt === e.length) return b;
throw b !== w && vt < e.length && o({
type: "end",
description: "end of input"
}), i(null, wt, _t);
}
return function(t, e) {
function n() {
this.constructor = t;
}
n.prototype = e.prototype, t.prototype = new n();
}(t, Error), {
SyntaxError: t,
parse: e
};
}();
},
542: function(t, e, n) {
"use strict";
function r(t) {
var e;
return p[t] ? t : (e = t.toLowerCase().replace("_", "-"), p[e] ? e : (e = e.split("-")[0], 
p[e] ? e : null));
}
function o(t) {
var e = r(t);
return p[e] ? p[e].c : null;
}
function i(t, e) {
var n = r(t);
if (!n) return -1;
if (!p[n].cFn) return 0;
var o = e + "", i = o.indexOf(".") < 0 ? "" : o.split(".")[1], c = i.length, a = +e, s = +o.split(".")[0], u = 0 === i.length ? 0 : +i.replace(/0+$/, "");
return p[n].cFn(a, s, c, +i, u);
}
function c(t, e) {
var n = r(t);
return n ? p[n].c[i(n, e)] : null;
}
function a(t) {
var e = r(t);
return p[e] ? p[e].o : null;
}
function s(t, e) {
var n = r(t);
if (!n) return -1;
if (!p[n].oFn) return 0;
var o = e + "", i = o.indexOf(".") < 0 ? "" : o.split(".")[1], c = i.length, a = +e, s = +o.split(".")[0], u = 0 === i.length ? 0 : +i.replace(/0+$/, "");
return p[n].oFn(a, s, c, +i, u);
}
function u(t, e) {
var n = r(t);
return p[n] ? p[n].o[s(n, e)] : null;
}
function l(t) {
return m[t];
}
function f(t, e) {
var n;
for (e.c = e.c ? e.c.map(l) : [ "other" ], e.o = e.o ? e.o.map(l) : [ "other" ], 
n = 0; n < t.length; n++) p[t[n]] = e;
}
function d(t, e, n) {
return t <= n && n <= e && n % 1 == 0;
}
function h(t, e) {
return t.indexOf(e) >= 0;
}
var p = {};
t.exports = c, t.exports.indexOf = i, t.exports.forms = o, t.exports.ordinal = u, 
t.exports.ordinal.indexOf = s, t.exports.ordinal.forms = a;
var m = [ "zero", "one", "two", "few", "many", "other" ];
f([ "af", "asa", "bem", "bez", "bg", "brx", "ce", "cgg", "chr", "ckb", "dv", "ee", "el", "eo", "es", "eu", "fo", "fur", "gsw", "ha", "haw", "jgo", "jmc", "kaj", "kcg", "kkj", "kl", "ks", "ksb", "ku", "ky", "lb", "lg", "mas", "mgo", "ml", "mn", "nah", "nb", "nd", "nn", "nnh", "no", "nr", "ny", "nyn", "om", "or", "os", "pap", "ps", "rm", "rof", "rwk", "saq", "sdh", "seh", "sn", "so", "ss", "ssy", "st", "syr", "ta", "te", "teo", "tig", "tk", "tn", "tr", "ts", "ug", "uz", "ve", "vo", "vun", "wae", "xh", "xog" ], {
c: [ 1, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 1;
}
}), f([ "ak", "bh", "guw", "ln", "mg", "nso", "pa", "ti", "wa" ], {
c: [ 1, 5 ],
cFn: function(t) {
return d(0, 1, t) ? 0 : 1;
}
}), f([ "am", "fa", "kn", "zu" ], {
c: [ 1, 5 ],
cFn: function(t, e) {
return 0 === e || 1 === t ? 0 : 1;
}
}), f([ "ar", "ars" ], {
c: [ 0, 1, 2, 3, 4, 5 ],
cFn: function(t) {
var e = t % 100;
return 0 === t ? 0 : 1 === t ? 1 : 2 === t ? 2 : d(3, 10, e) ? 3 : d(11, 99, e) ? 4 : 5;
}
}), f([ "as", "bn" ], {
c: [ 1, 5 ],
cFn: function(t, e) {
return 0 === e || 1 === t ? 0 : 1;
},
o: [ 1, 2, 3, 4, 5 ],
oFn: function(t) {
return h([ 1, 5, 7, 8, 9, 10 ], t) ? 0 : h([ 2, 3 ], t) ? 1 : 4 === t ? 2 : 6 === t ? 3 : 4;
}
}), f([ "ast", "de", "et", "fi", "fy", "gl", "ji", "nl", "sw", "ur", "yi" ], {
c: [ 1, 5 ],
cFn: function(t, e, n) {
return 1 === e && 0 === n ? 0 : 1;
}
}), f([ "az" ], {
c: [ 1, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 1;
},
o: [ 1, 3, 4, 5 ],
oFn: function(t, e) {
var n = e % 10, r = e % 100, o = e % 1e3;
return h([ 1, 2, 5, 7, 8 ], n) || h([ 20, 50, 70, 80 ], r) ? 0 : h([ 3, 4 ], n) || h([ 100, 200, 300, 400, 500, 600, 700, 800, 900 ], o) ? 1 : 0 === e || 6 === n || h([ 40, 60, 90 ], r) ? 2 : 3;
}
}), f([ "be" ], {
c: [ 1, 3, 4, 5 ],
cFn: function(t) {
var e = t % 10, n = t % 100;
return 1 === e && 11 !== n ? 0 : d(2, 4, e) && !d(12, 14, n) ? 1 : 0 === e || d(5, 9, e) || d(11, 14, n) ? 2 : 3;
},
o: [ 3, 5 ],
oFn: function(t) {
var e = t % 10, n = t % 100;
return h([ 2, 3 ], e) && !h([ 12, 13 ], n) ? 0 : 1;
}
}), f([ "bm", "bo", "dz", "id", "ig", "ii", "in", "ja", "jbo", "jv", "jw", "kde", "kea", "km", "ko", "lkt", "my", "nqo", "root", "sah", "ses", "sg", "th", "to", "wo", "yo", "yue", "zh" ], {}), 
f([ "br" ], {
c: [ 1, 2, 3, 4, 5 ],
cFn: function(t) {
var e = t % 10, n = t % 100, r = t % 1e6;
return 1 !== e || h([ 11, 71, 91 ], n) ? 2 !== e || h([ 12, 72, 92 ], n) ? !d(3, 4, e) && 9 !== e || d(10, 19, n) || d(70, 79, n) || d(90, 99, n) ? 0 !== t && 0 === r ? 3 : 4 : 2 : 1 : 0;
}
}), f([ "bs", "hr", "sh", "sr" ], {
c: [ 1, 3, 5 ],
cFn: function(t, e, n, r) {
var o = e % 10, i = e % 100, c = r % 10, a = r % 100;
return 0 === n && 1 === o && 11 !== i || 1 === c && 11 !== a ? 0 : 0 === n && d(2, 4, o) && !d(12, 14, i) || d(2, 4, c) && !d(12, 14, a) ? 1 : 2;
}
}), f([ "ca" ], {
c: [ 1, 5 ],
cFn: function(t, e, n) {
return 1 === e && 0 === n ? 0 : 1;
},
o: [ 1, 2, 3, 5 ],
oFn: function(t) {
return h([ 1, 3 ], t) ? 0 : 2 === t ? 1 : 4 === t ? 2 : 3;
}
}), f([ "cs", "sk" ], {
c: [ 1, 3, 4, 5 ],
cFn: function(t, e, n) {
return 1 === e && 0 === n ? 0 : d(2, 4, e) && 0 === n ? 1 : 0 !== n ? 2 : 3;
}
}), f([ "cy" ], {
c: [ 0, 1, 2, 3, 4, 5 ],
cFn: function(t) {
return 0 === t ? 0 : 1 === t ? 1 : 2 === t ? 2 : 3 === t ? 3 : 6 === t ? 4 : 5;
},
o: [ 0, 1, 2, 3, 4, 5 ],
oFn: function(t) {
return h([ 0, 7, 8, 9 ], t) ? 0 : 1 === t ? 1 : 2 === t ? 2 : h([ 3, 4 ], t) ? 3 : h([ 5, 6 ], t) ? 4 : 5;
}
}), f([ "da" ], {
c: [ 1, 5 ],
cFn: function(t, e, n, r, o) {
return 1 === t || 0 !== o && h([ 0, 1 ], e) ? 0 : 1;
}
}), f([ "dsb", "hsb" ], {
c: [ 1, 2, 3, 5 ],
cFn: function(t, e, n, r) {
var o = e % 100, i = r % 100;
return 0 === n && 1 === o || 1 === i ? 0 : 0 === n && 2 === o || 2 === i ? 1 : 0 === n && d(3, 4, o) || d(3, 4, i) ? 2 : 3;
}
}), f([ "en" ], {
c: [ 1, 5 ],
cFn: function(t, e, n) {
return 1 === e && 0 === n ? 0 : 1;
},
o: [ 1, 2, 3, 5 ],
oFn: function(t) {
var e = t % 10, n = t % 100;
return 1 === e && 11 !== n ? 0 : 2 === e && 12 !== n ? 1 : 3 === e && 13 !== n ? 2 : 3;
}
}), f([ "ff", "kab" ], {
c: [ 1, 5 ],
cFn: function(t, e) {
return h([ 0, 1 ], e) ? 0 : 1;
}
}), f([ "fil", "tl" ], {
c: [ 1, 5 ],
cFn: function(t, e, n, r) {
var o = e % 10, i = r % 10;
return 0 === n && h([ 1, 2, 3 ], e) || 0 === n && !h([ 4, 6, 9 ], o) || 0 !== n && !h([ 4, 6, 9 ], i) ? 0 : 1;
},
o: [ 1, 5 ],
oFn: function(t) {
return 1 === t ? 0 : 1;
}
}), f([ "fr", "hy" ], {
c: [ 1, 5 ],
cFn: function(t, e) {
return h([ 0, 1 ], e) ? 0 : 1;
},
o: [ 1, 5 ],
oFn: function(t) {
return 1 === t ? 0 : 1;
}
}), f([ "ga" ], {
c: [ 1, 2, 3, 4, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 2 === t ? 1 : d(3, 6, t) ? 2 : d(7, 10, t) ? 3 : 4;
},
o: [ 1, 5 ],
oFn: function(t) {
return 1 === t ? 0 : 1;
}
}), f([ "gd" ], {
c: [ 1, 2, 3, 5 ],
cFn: function(t) {
return h([ 1, 11 ], t) ? 0 : h([ 2, 12 ], t) ? 1 : d(3, 10, t) || d(13, 19, t) ? 2 : 3;
}
}), f([ "gu", "hi" ], {
c: [ 1, 5 ],
cFn: function(t, e) {
return 0 === e || 1 === t ? 0 : 1;
},
o: [ 1, 2, 3, 4, 5 ],
oFn: function(t) {
return 1 === t ? 0 : h([ 2, 3 ], t) ? 1 : 4 === t ? 2 : 6 === t ? 3 : 4;
}
}), f([ "gv" ], {
c: [ 1, 2, 3, 4, 5 ],
cFn: function(t, e, n) {
var r = e % 10, o = e % 100;
return 0 === n && 1 === r ? 0 : 0 === n && 2 === r ? 1 : 0 === n && h([ 0, 20, 40, 60, 80 ], o) ? 2 : 0 !== n ? 3 : 4;
}
}), f([ "he", "iw" ], {
c: [ 1, 2, 4, 5 ],
cFn: function(t, e, n) {
var r = t % 10;
return 1 === e && 0 === n ? 0 : 2 === e && 0 === n ? 1 : 0 !== n || d(0, 10, t) || 0 !== r ? 3 : 2;
}
}), f([ "hu" ], {
c: [ 1, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 1;
},
o: [ 1, 5 ],
oFn: function(t) {
return h([ 1, 5 ], t) ? 0 : 1;
}
}), f([ "is" ], {
c: [ 1, 5 ],
cFn: function(t, e, n, r, o) {
var i = e % 10, c = e % 100;
return 0 === o && 1 === i && 11 !== c || 0 !== o ? 0 : 1;
}
}), f([ "it" ], {
c: [ 1, 5 ],
cFn: function(t, e, n) {
return 1 === e && 0 === n ? 0 : 1;
},
o: [ 4, 5 ],
oFn: function(t) {
return h([ 11, 8, 80, 800 ], t) ? 0 : 1;
}
}), f([ "iu", "kw", "naq", "se", "sma", "smi", "smj", "smn", "sms" ], {
c: [ 1, 2, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 2 === t ? 1 : 2;
}
}), f([ "ka" ], {
c: [ 1, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 1;
},
o: [ 1, 4, 5 ],
oFn: function(t, e) {
var n = e % 100;
return 1 === e ? 0 : 0 === e || d(2, 20, n) || 40 === n || 60 === n || 80 === n ? 1 : 2;
}
}), f([ "kk" ], {
c: [ 1, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 1;
},
o: [ 4, 5 ],
oFn: function(t) {
var e = t % 10;
return 6 === e || 9 === e || 0 === e && 0 !== t ? 0 : 1;
}
}), f([ "ksh" ], {
c: [ 0, 1, 5 ],
cFn: function(t) {
return 0 === t ? 0 : 1 === t ? 1 : 2;
}
}), f([ "lag" ], {
c: [ 0, 1, 5 ],
cFn: function(t, e) {
return 0 === t ? 0 : h([ 0, 1 ], e) && 0 !== t ? 1 : 2;
}
}), f([ "lo", "ms", "vi" ], {
o: [ 1, 5 ],
oFn: function(t) {
return 1 === t ? 0 : 1;
}
}), f([ "lt" ], {
c: [ 1, 3, 4, 5 ],
cFn: function(t, e, n, r) {
var o = t % 10, i = t % 100;
return 1 !== o || d(11, 19, i) ? d(2, 9, o) && !d(11, 19, i) ? 1 : 0 !== r ? 2 : 3 : 0;
}
}), f([ "lv", "prg" ], {
c: [ 0, 1, 5 ],
cFn: function(t, e, n, r) {
var o = t % 10, i = t % 100, c = r % 100, a = r % 10;
return 0 === o || d(11, 19, i) || 2 === n && d(11, 19, c) ? 0 : 1 === o && 11 !== i || 2 === n && 1 === a && 11 !== c || 2 !== n && 1 === a ? 1 : 2;
}
}), f([ "mk" ], {
c: [ 1, 5 ],
cFn: function(t, e, n, r) {
var o = e % 10, i = r % 10;
return 0 === n && 1 === o || 1 === i ? 0 : 1;
},
o: [ 1, 2, 4, 5 ],
oFn: function(t, e) {
var n = e % 10, r = e % 100;
return 1 === n && 11 !== r ? 0 : 2 === n && 12 !== r ? 1 : h([ 7, 8 ], n) && !h([ 17, 18 ], r) ? 2 : 3;
}
}), f([ "mo", "ro" ], {
c: [ 1, 3, 5 ],
cFn: function(t, e, n) {
var r = t % 100;
return 1 === e && 0 === n ? 0 : 0 !== n || 0 === t || 1 !== t && d(1, 19, r) ? 1 : 2;
},
o: [ 1, 5 ],
oFn: function(t) {
return 1 === t ? 0 : 1;
}
}), f([ "mr" ], {
c: [ 1, 5 ],
cFn: function(t, e) {
return 0 === e || 1 === t ? 0 : 1;
},
o: [ 1, 2, 3, 5 ],
oFn: function(t) {
return 1 === t ? 0 : h([ 2, 3 ], t) ? 1 : 4 === t ? 2 : 3;
}
}), f([ "mt" ], {
c: [ 1, 3, 4, 5 ],
cFn: function(t) {
var e = t % 100;
return 1 === t ? 0 : 0 === t || d(2, 10, e) ? 1 : d(11, 19, e) ? 2 : 3;
}
}), f([ "ne" ], {
c: [ 1, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 1;
},
o: [ 1, 5 ],
oFn: function(t) {
return d(1, 4, t) ? 0 : 1;
}
}), f([ "pl" ], {
c: [ 1, 3, 4, 5 ],
cFn: function(t, e, n) {
var r = e % 10, o = e % 100;
return 1 === e && 0 === n ? 0 : 0 === n && d(2, 4, r) && !d(12, 14, o) ? 1 : 0 === n && 1 !== e && d(0, 1, r) || 0 === n && d(5, 9, r) || 0 === n && d(12, 14, o) ? 2 : 3;
}
}), f([ "pt" ], {
c: [ 1, 5 ],
cFn: function(t) {
return d(0, 2, t) && 2 !== t ? 0 : 1;
}
}), f([ "pt-pt" ], {
c: [ 1, 5 ],
cFn: function(t, e, n) {
return 1 === t && 0 === n ? 0 : 1;
}
}), f([ "ru" ], {
c: [ 1, 3, 4, 5 ],
cFn: function(t, e, n) {
var r = e % 10, o = e % 100;
return 0 === n && 1 === r && 11 !== o ? 0 : 0 === n && d(2, 4, r) && !d(12, 14, o) ? 1 : 0 === n && 0 === r || 0 === n && d(5, 9, r) || 0 === n && d(11, 14, o) ? 2 : 3;
}
}), f([ "shi" ], {
c: [ 1, 3, 5 ],
cFn: function(t, e) {
return 0 === e || 1 === t ? 0 : d(2, 10, t) ? 1 : 2;
}
}), f([ "si" ], {
c: [ 1, 5 ],
cFn: function(t, e, n, r) {
return h([ 0, 1 ], t) || 0 === e && 1 === r ? 0 : 1;
}
}), f([ "sl" ], {
c: [ 1, 2, 3, 5 ],
cFn: function(t, e, n) {
var r = e % 100;
return 0 === n && 1 === r ? 0 : 0 === n && 2 === r ? 1 : 0 === n && d(3, 4, r) || 0 !== n ? 2 : 3;
}
}), f([ "sq" ], {
c: [ 1, 5 ],
cFn: function(t) {
return 1 === t ? 0 : 1;
},
o: [ 1, 4, 5 ],
oFn: function(t) {
var e = t % 10, n = t % 100;
return 1 === t ? 0 : 4 === e && 14 !== n ? 1 : 2;
}
}), f([ "sv" ], {
c: [ 1, 5 ],
cFn: function(t, e, n) {
return 1 === e && 0 === n ? 0 : 1;
},
o: [ 1, 5 ],
oFn: function(t) {
var e = t % 10, n = t % 100;
return h([ 1, 2 ], e) && !h([ 11, 12 ], n) ? 0 : 1;
}
}), f([ "tzm" ], {
c: [ 1, 5 ],
cFn: function(t) {
return d(0, 1, t) || d(11, 99, t) ? 0 : 1;
}
}), f([ "uk" ], {
c: [ 1, 3, 4, 5 ],
cFn: function(t, e, n) {
var r = e % 10, o = e % 100;
return 0 === n && 1 === r && 11 !== o ? 0 : 0 === n && d(2, 4, r) && !d(12, 14, o) ? 1 : 0 === n && 0 === r || 0 === n && d(5, 9, r) || 0 === n && d(11, 14, o) ? 2 : 3;
},
o: [ 3, 5 ],
oFn: function(t) {
var e = t % 10, n = t % 100;
return 3 === e && 13 !== n ? 0 : 1;
}
});
},
563: function(t, e, n) {
"use strict";
n(564), n(569);
},
564: function(t, e, n) {
"use strict";
function r(t) {
if (t.length) {
if (1 === t.length) return "string" == typeof t[0] ? document.createTextNode(t[0]) : t[0];
for (var e, n = document.createDocumentFragment(), r = t.length, o = -1; ++o < r; ) e = t[o], 
n.appendChild("string" == typeof e ? document.createTextNode(e) : e);
return n;
}
throw Error("DOM Exception 8");
}
var o = {
matches: Element.prototype.matchesSelector || Element.prototype.webkitMatchesSelector || Element.prototype.mozMatchesSelector || Element.prototype.msMatchesSelector || Element.prototype.oMatchesSelector,
replace: function() {
this.parentNode && this.parentNode.replaceChild(r(arguments), this);
},
prepend: function() {
this.insertBefore(r(arguments), this.firstChild);
},
append: function() {
this.appendChild(r(arguments));
},
remove: function() {
var t = this.parentNode;
if (t) return t.removeChild(this);
},
before: function() {
this.parentNode && this.parentNode.insertBefore(r(arguments), this);
},
after: function() {
this.parentNode && this.parentNode.insertBefore(r(arguments), this.nextSibling);
},
closest: function(t) {
for (var e = this; e; ) {
if (e.matches && e.matches(t)) return e;
e = e.parentElement;
}
return null;
}
};
for (var i in o) Element.prototype[i] || (Element.prototype[i] = o[i]);
n(565), n(566), n(567), n(568);
},
565: function(t, e, n) {
"use strict";
try {
new CustomEvent("IE has CustomEvent, but doesn't support constructor");
} catch (t) {
window.CustomEvent = function(t, e) {
var n;
return e = e || {
bubbles: !1,
cancelable: !1,
detail: void 0
}, n = document.createEvent("CustomEvent"), n.initCustomEvent(t, e.bubbles, e.cancelable, e.detail), 
n;
}, CustomEvent.prototype = Object.create(window.Event.prototype);
}
},
566: function(t, e, n) {
"use strict";
if (!(document.documentElement.dataset || Object.getOwnPropertyDescriptor(Element.prototype, "dataset") && Object.getOwnPropertyDescriptor(Element.prototype, "dataset").get)) {
var r = {
enumerable: !0,
get: function() {
var t, e, n, r, o, i, c = this, a = this.attributes, s = a.length, u = function(t) {
return t.charAt(1).toUpperCase();
}, l = function() {
return this;
}, f = function(t, e) {
return void 0 !== e ? this.setAttribute(t, e) : this.removeAttribute(t);
};
try {
({}).__defineGetter__("test", function() {}), e = {};
} catch (t) {
e = document.createElement("div");
}
for (t = 0; t < s; t++) if ((i = a[t]) && i.name && /^data-\w[\w\-]*$/.test(i.name)) {
n = i.value, r = i.name, o = r.substr(5).replace(/-./g, u);
try {
Object.defineProperty(e, o, {
enumerable: this.enumerable,
get: l.bind(n || ""),
set: f.bind(c, r)
});
} catch (t) {
e[o] = n;
}
}
return e;
}
};
try {
Object.defineProperty(Element.prototype, "dataset", r);
} catch (t) {
r.enumerable = !1, Object.defineProperty(Element.prototype, "dataset", r);
}
}
},
567: function(t, e, n) {
"use strict";
void 0 === document.documentElement.hidden && (document.head.insertAdjacentHTML("beforeEnd", "<style> [hidden] { display: none } </style>"), 
Object.defineProperty(Element.prototype, "hidden", {
set: function(t) {
this.setAttribute("hidden", t);
},
get: function() {
return this.getAttribute("hidden");
}
}));
},
568: function(t, e, n) {
"use strict";
!function() {
var t = 0;
window.requestAnimationFrame || (window.requestAnimationFrame = function(e, n) {
var r = new Date().getTime(), o = Math.max(0, 16 - (r - t)), i = window.setTimeout(function() {
e(r + o);
}, o);
return t = r + o, i;
}), window.cancelAnimationFrame || (window.cancelAnimationFrame = function(t) {
clearTimeout(t);
});
}();
},
569: function(t, e, n) {
"use strict";
var r = "function" == typeof Symbol && "symbol" == typeof Symbol.iterator ? function(t) {
return typeof t;
} : function(t) {
return t && "function" == typeof Symbol && t.constructor === Symbol && t !== Symbol.prototype ? "symbol" : typeof t;
};
String.prototype.startsWith || (String.prototype.startsWith = function(t) {
var e = arguments.length < 2 ? 0 : arguments[1];
return 0 === this.slice(e).indexOf(t);
}), String.prototype.endsWith || (String.prototype.endsWith = function(t) {
var e = arguments.length < 2 ? this.length : arguments[1], n = this.lastIndexOf(t);
return -1 !== n && n === e - t.length;
}), String.prototype.includes || (String.prototype.includes = function(t, e) {
if ("object" === (void 0 === t ? "undefined" : r(t)) && t instanceof RegExp) throw new TypeError("First argument to String.prototype.includes must not be a regular expression");
return -1 !== this.indexOf(t, e);
});
},
571: function(t, e, n) {
"use strict";
var r = n(572), o = n(575), i = [];
e.iframe = function(t) {
!function() {
r.async(t, function(e, n) {
n && (t.style.height = n + "px");
});
}();
}, e.codeTabs = function(t) {
function e() {
var e = t.closest(".code-tabs"), n = (t.closest("[data-code-tabs-content]"), e.querySelector("[data-code-tabs-switches]"));
n.firstElementChild.offsetWidth > n.offsetWidth ? e.classList.add("code-tabs_scroll") : e.classList.remove("code-tabs_scroll");
}
e(), i.push(e);
}, window.addEventListener("resize", o(function() {
i.forEach(function(t) {
t();
});
}, 200));
},
572: function(t, e, n) {
"use strict";
function r(t, e) {
function n(t, n) {
clearTimeout(r), e(t, n);
}
var r = setTimeout(function() {
e(Error("timeout"));
}, 500);
try {
(t.contentDocument || t.contentWindow.document).body;
} catch (e) {
o(t, n);
}
if (!t.offsetWidth) {
var c = t.cloneNode(!0);
return c.name = "", c.style.height = "50px", c.style.position = "absolute", c.style.display = "block", 
c.style.top = "10000px", c.onload = function() {
var e = i(this.contentDocument);
t.style.display = "block", c.remove(), n(null, e);
}, void document.body.appendChild(c);
}
t.style.display = "block", t.style.height = "1px";
var a = i(t.contentDocument);
t.style.height = "", n(null, a);
}
function o(t, e) {
throw Error("Not implemented yet");
}
var i = n(573);
r.async = function(t, e) {
setTimeout(function() {
r(t, e);
}, 0);
}, t.exports = r;
},
573: function(t, e, n) {
"use strict";
function r(t) {
t = t || document;
var e = Math.max(t.body.scrollHeight, t.documentElement.scrollHeight, t.body.offsetHeight, t.documentElement.offsetHeight, t.body.clientHeight, t.documentElement.clientHeight);
return t.documentElement.scrollWidth > t.documentElement.clientWidth && (o || (o = i()), 
e += o), e;
}
var o, i = n(574);
t.exports = r;
},
574: function(t, e, n) {
"use strict";
function r() {
var t = document.createElement("div");
if (t.style.cssText = "visibility:hidden;height:100px", !document.body) throw Error("getScrollbarHeight called to early: no document.body");
document.body.appendChild(t);
var e = t.offsetWidth;
t.style.overflow = "scroll";
var n = document.createElement("div");
n.style.width = "100%", t.appendChild(n);
var r = n.offsetWidth;
return t.parentNode.removeChild(t), e - r;
}
t.exports = r;
},
575: function(t, e, n) {
"use strict";
function r(t, e) {
function n() {
if (i) return r = arguments, void (o = this);
t.apply(this, arguments), i = !0, setTimeout(function() {
i = !1, r && (n.apply(o, r), r = o = null);
}, e);
}
var r, o, i = !1;
return n;
}
t.exports = r;
},
576: function(t, e, n) {
"use strict";
function r() {}
function o() {
r("onWindowScrollAndResizeThrottled", u), u || (u = window.requestAnimationFrame(function() {
c(), u = null;
}));
}
function i() {
r("compactifySidebar");
var t = document.querySelector(".sidebar"), e = t.querySelector(".sidebar__content"), n = t.querySelector(".sidebar__inner"), o = t.classList.contains("sidebar_sticky-footer");
if (t.classList.contains("sidebar_compact")) {
var i;
i = o ? e.lastElementChild.getBoundingClientRect().top - e.lastElementChild.previousElementSibling.getBoundingClientRect().bottom : e.getBoundingClientRect().bottom - e.lastElementChild.getBoundingClientRect().bottom, 
r("decompact?", i), i > 150 && t.classList.remove("sidebar_compact");
} else r(n.scrollHeight, n.clientHeight), n.scrollHeight > n.clientHeight && (r("compact!"), 
t.classList.add("sidebar_compact"));
}
function c() {
var t = document.querySelector(".sitetoolbar");
if (!t) return void r("no sitetoolbar");
var e = document.querySelector(".sidebar");
e && (e.style.top = Math.max(t.getBoundingClientRect().bottom, 0) + "px", i()), 
a(), s();
}
function a() {
var t = document.documentElement.clientWidth <= l, e = document.querySelector('meta[name="viewport"]').content;
e = e.replace(/user-scalable=\w+/, "user-scalable=" + (t ? "yes" : "no")), document.querySelector('meta[name="viewport"]').content = e;
}
function s() {
var t = "//" + window.disqus_shortname + ".disqus.com/embed.js";
window.disqus_shortname;
if (window.disqus_enabled && !document.querySelector('script[src="' + t + '"]')) {
var e = document.getElementById("disqus_thread");
if (!e.hasChildNodes()) {
var n = e.getBoundingClientRect();
if (!(n.top > document.documentElement.clientHeight + 150 || n.bottom < -150)) {
var r = document.createElement("script");
r.src = t, r.setAttribute("data-timestamp", +new Date()), document.head.appendChild(r);
}
}
}
}
var u, l = 840;
window.addEventListener("resize-internal", o), window.addEventListener("scroll", o), 
window.addEventListener("resize", o), "loading" == document.readyState ? document.addEventListener("DOMContentLoaded", o) : o();
},
577: function(t, e, n) {
"use strict";
function r(t) {
if (t.target.closest) {
var e = t.target.closest("[data-dropdown-toggler]");
e && (e.nextElementSibling.style.display = e.nextElementSibling.offsetWidth ? "none" : "block");
}
}
function o(t) {
if (t.target.closest) {
t.target.closest(".sitetoolbar__nav-toggle") && (t.target.classList.toggle("sitetoolbar__nav-toggle--active"), 
document.querySelector(".sitetoolbar").classList.toggle("sitetoolbar_menu_open"));
}
}
function i(t) {
if (t.target.closest) {
t.target.closest(l + "__search-toggle") && (s || c(), a());
}
}
function c() {
var t, e = document.querySelector(l), n = e.querySelector(l + "__search-input input"), r = e.querySelector(l + "__find");
r.onmousedown = function(e) {
t = !0;
}, n.onkeydown = function(t) {
27 == t.keyCode && (this.value = "", a());
}, n.onblur = function(e) {
!t && a();
}, s = !0;
}
function a() {
var t, e = document.querySelector(l);
e.classList.toggle(u + "_search_open");
var n = e.querySelector(l + "__search-input input");
e.classList.contains(u + "_search_open") ? (n.focus(), t = document.createElement("div"), 
t.className = "search-paranja", t.style.top = e.offsetHeight + "px", document.body.appendChild(t), 
document.body.classList.add("paranja-open")) : (t = document.querySelector(".search-paranja"), 
t.parentNode.removeChild(t), document.body.classList.remove("paranja-open"));
}
document.addEventListener("click", i), document.addEventListener("click", r), document.addEventListener("click", o);
var s = !1, u = "sitetoolbar", l = "." + u;
},
578: function(t, e, n) {
"use strict";
function r() {
var t = document.querySelector(".page-wrapper");
document.querySelector(".page").classList.toggle("page_sidebar_on"), t && t.classList.toggle("page-wrapper_sidebar_on"), 
document.querySelector(".page").classList.contains("page_sidebar_on") ? delete localStorage.noSidebar : localStorage.noSidebar = 1;
}
function o(t) {
t.target.hasAttribute("data-sidebar-toggle") && r();
}
function i(t) {
if (!(document.activeElement && ~[ "INPUT", "TEXTAREA", "SELECT" ].indexOf(document.activeElement.tagName) || t.keyCode != "S".charCodeAt(0))) {
if (~navigator.userAgent.toLowerCase().indexOf("mac os x")) {
if (!t.metaKey || !t.altKey) return;
} else if (!t.altKey) return;
r(), t.preventDefault();
}
}
document.addEventListener("click", o), document.addEventListener("keydown", i);
},
579: function(t, e, n) {
"use strict";
function r(t) {
if ((!document.activeElement || !~[ "INPUT", "TEXTAREA", "SELECT" ].indexOf(document.activeElement.tagName)) && t[c + "Key"]) {
var e = null;
switch (t.keyCode) {
case 37:
e = "prev";
break;

case 39:
e = "next";
break;

default:
return;
}
var n = document.querySelector('link[rel="' + e + '"]');
n && (document.location = n.href, t.preventDefault());
}
}
function o() {
var t, e = c[0].toUpperCase() + c.slice(1), n = document.querySelector('link[rel="next"]');
n && (t = document.querySelector('a[href="' + n.getAttribute("href") + '"] .page__nav-text-shortcut'), 
t.innerHTML = e + ' + <span class="page__nav-text-arr">→</span>');
var r = document.querySelector('link[rel="prev"]');
r && (t = document.querySelector('a[href="' + r.getAttribute("href") + '"] .page__nav-text-shortcut'), 
t.innerHTML = e + ' + <span class="page__nav-text-arr">←</span>');
}
var i = n(580), c = ~navigator.userAgent.toLowerCase().indexOf("mac os x") ? "ctrl" : "alt";
i(document, {
onRight: function() {
var t = document.querySelector('link[rel="prev"]');
t && (document.location = t.href);
},
onLeft: function() {
var t = document.querySelector('link[rel="next"]');
t && (document.location = t.href);
}
}), document.addEventListener("keydown", r), "loading" == document.readyState ? document.addEventListener("DOMContentLoaded", o) : o();
},
580: function(t, e, n) {
"use strict";
function r(t, e) {
e = e || {};
var n, r, o, i, c, a = e.onRight || function() {}, s = e.onLeft || function() {}, u = e.tolerance || 50, l = e.threshold || 150, f = e.allowedTime || 500;
t.addEventListener("touchstart", function(t) {
var e = t.changedTouches[0];
o = 0, n = e.pageX, r = e.pageY, c = Date.now();
}), t.addEventListener("touchend", function(t) {
var e = t.changedTouches[0];
if (o = e.pageX - n, i = Date.now() - c, !(Math.abs(e.pageY - r) > u || i > f)) {
for (var d = !1, h = t.target; h != document.body; ) {
if (h.scrollWidth > h.clientWidth) {
d = !0;
break;
}
h = h.parentElement;
}
d || (o > l && a(t), o < -l && s(t));
}
});
}
t.exports = r;
},
581: function(t, e, n) {
"use strict";
var r;
document.addEventListener("mouseover", function(t) {
if (t.target.closest) {
var e = t.target.closest("[data-add-class-on-hover]") || t.target.closest(".button");
e && (r = e, e.classList.add("hover"));
}
}), document.addEventListener("touchend", function(t) {
setTimeout(function() {
r && (r.classList.remove("hover"), r = null);
}, 500);
}), document.addEventListener("mouseout", function(t) {
r && (r.contains(t.relatedTarget) || (r.classList.remove("hover"), r = null));
}), navigator.userAgent.match(/(iPad|iPhone|iPod)/g) || document.documentElement.classList.add("working-hover");
},
582: function(t, e, n) {
"use strict";
var r = window.location.host;
document.addEventListener("click", function(t) {
function e() {
document.location = o;
}
if (1 == t.which && !t.defaultPrevented) {
var n = t.target.closest && t.target.closest("a");
if (n && (r != n.host || n.hasAttribute("data-track-outbound")) && ~[ "_self", "_top", "_parent" ].indexOf(n.target) && !(t.shiftKey || t.ctrlKey || t.altKey)) {
t.preventDefault();
var o = n.href;
window.ga("send", "event", "outbound", "click", o, {
hitCallback: e
}), setTimeout(e, 500);
}
}
});
},
672: function(t, e) {
t.exports = {
toolbar: {
logo: {
normal: {
svg: "sitetoolbar__logo_en.svg",
width: 200
},
"normal-white": {
svg: "sitetoolbar__logo_en-white.svg"
},
small: {
svg: "sitetoolbar__logo_small_en.svg",
width: 70
},
"small-white": {
svg: "sitetoolbar__logo_small_en-white.svg"
}
},
sections: [],
buy_ebook_extra: "Buy",
buy_ebook: "EPUB/PDF",
search_placeholder: "Search on Javascript.info",
search_button: "Search",
public_profile: "Public profile",
account: "Account",
notifications: "Notifications",
admin: "Admin",
logout: "Logout"
},
errors: {
server_connection_error: "Server connection error.",
server_request_timeout: "Server request timeout.",
request_aborted: "Request was aborted.",
no_response: "No response from server.",
server_error: "Server error (код #{status}), try again later.",
invalid_format: "Invalid response format."
},
sorry_old_browser: "Sorry, IE<10 is not supported, please use a newer browser.",
contact_us: "contact us",
about_the_project: "about the project",
ilya_kantor: "Ilya Kantor",
comments: "Comments",
loading: "Loading...",
search: "Search",
share: "Share",
donate: "Donate",
read_before_commenting: "read this before commenting…",
"tablet-menu": {
choose_section: "Choose section",
search_placeholder: "Search in the tutorial",
search_button: "Search"
},
tutorial_map: "Tutorial map",
comment: {
help: [ "You're welcome to post additions, questions to the articles and answers to them.", "To insert a few words of code, use the <code>&lt;code&gt;</code> tag, for several lines – use <code>&lt;pre&gt;</code>, for more than 10 lines – use a sandbox (<a href='http://plnkr.co/edit/?p=preview'>plnkr</a>, <a href='http://jsbin.com'>JSBin</a>, <a href='http://codepen.io'>codepen</a>…)", "If you can't understand something in the article – please elaborate." ]
},
edit_on_github: "Edit on Github",
hide_forever: "hide permanently",
Error: "Error",
close: "close",
Close: "Close"
};
},
673: function(t, e) {
t.exports = {
toolbar: {
logo: {
normal: {
svg: "sitetoolbar__logo_ru.svg",
width: 171
},
"normal-white": {
svg: "sitetoolbar__logo_ru.svg"
},
small: {
svg: "sitetoolbar__logo_small_ru.svg",
width: 80
},
"small-white": {
svg: "sitetoolbar__logo_small_ru.svg"
}
},
sections: [ {
slug: "tutorial",
title: "Учебник"
}, {
slug: "courses",
title: "Курсы"
}, {
url: "https://javascript.ru/forum/",
title: "Форум"
}, {
url: "https://es5.javascript.ru",
title: "ES5"
}, {
slug: "quiz",
title: "Тесты знаний"
} ],
buy_ebook_extra: "Купить",
buy_ebook: "EPUB/PDF",
search_placeholder: "Искать на Javascript.ru",
search_button: "Найти",
public_profile: "Публичный профиль",
account: "Аккаунт",
notifications: "Уведомления",
admin: "Админ",
logout: "Выйти"
},
errors: {
server_connection_error: "Ошибка связи с сервером.",
server_request_timeout: "Превышено максимально допустимое время ожидания ответа от сервера.",
request_aborted: "Запрос был прерван.",
no_response: "Не получен ответ от сервера.",
server_error: "Ошибка на стороне сервера (код #{status}), попытайтесь позднее.",
invalid_format: "Некорректный формат ответа от сервера."
},
sorry_old_browser: "Извините, IE<10 не поддерживается, пожалуйста используйте более новый браузер.",
contact_us: "связаться с нами",
about_the_project: "о проекте",
ilya_kantor: "Илья Кантор",
comments: "Комментарии",
loading: "Загружается...",
search: "Искать",
share: "Поделиться",
donate: "Поддержать",
read_before_commenting: "перед тем как писать…",
"tablet-menu": {
choose_section: "Выберите раздел",
search_placeholder: "Поиск в учебнике",
search_button: "Поиск"
},
tutorial_map: "Карта учебника",
comment: {
help: [ "Приветствуются комментарии, содержащие дополнения и вопросы по статье, и ответы на них.", "Для одной строки кода используйте тег <code>&lt;code&gt;</code>, для нескольких строк кода&nbsp;&mdash; тег <code>&lt;pre&gt;</code>, если больше 10 строк&nbsp;&mdash; ссылку на песочницу (<a href='http://plnkr.co/edit/?p=preview'>plnkr</a>, <a href='http://jsbin.com'>JSBin</a>, <a href='http://codepen.io'>codepen</a>…)", "Если что-то непонятно в статье&nbsp;&mdash; пишите, что именно и с какого места." ]
},
edit_on_github: "Редактировать на Github",
hide_forever: "не показывать",
Error: "Ошибка",
close: "закрыть",
Close: "Закрыть"
};
},
683: function(t, e, n) {
"use strict";
function r() {
var t = new o({
hasClose: !1,
mixClass: "login-modal"
}), e = new i();
t.setContent(e.elem), e.start(), n.e(2).then(function() {
t.remove(), new (n(528))();
}.bind(null, n)).catch(n.oe);
}
var o = n(529), i = n(526), c = !0, a = !1, s = void 0;
try {
for (var u, l = document.querySelectorAll("[data-action-login]")[Symbol.iterator](); !(c = (u = l.next()).done); c = !0) {
var f = u.value, d = !0, h = !1, p = void 0;
try {
for (var m, v = f.classList[Symbol.iterator](); !(d = (m = v.next()).done); d = !0) {
var y = m.value;
y.endsWith("_unready") && f.classList.remove(y);
}
} catch (t) {
h = !0, p = t;
} finally {
try {
!d && v.return && v.return();
} finally {
if (h) throw p;
}
}
}
} catch (t) {
a = !0, s = t;
} finally {
try {
!c && l.return && l.return();
} finally {
if (a) throw s;
}
}
document.addEventListener("click", function(t) {
t.target.hasAttribute("data-action-login") && (t.preventDefault(), r());
}), t.exports = r;
},
684: function(t, e, n) {
"use strict";
function r() {
var t = document.createElement("form");
t.method = "POST", t.action = "/auth/logout?_csrf=" + document.cookie.match(/XSRF-TOKEN=([\w-]+)/)[1], 
document.body.appendChild(t), t.submit();
}
document.addEventListener("click", function(t) {
t.target.hasAttribute("data-action-user-logout") && (t.preventDefault(), r());
}), t.exports = r;
}
});