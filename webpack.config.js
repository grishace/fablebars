var path = require("path");
var webpack = require("webpack");

var cfg = {
  devtool: "source-map",
  entry: "./temp/src/code.js",
  output: {
    path: path.join(__dirname, "public"),
    filename: "bundle.js"
  },
  module: {
    loaders: [
      {
        test: /\.js$/,
        exclude: /node_modules/,
        loader: "source-map-loader"
      },
      { 
        test: /\.handlebars$/, 
        loader: "handlebars-loader"
      }      
    ]
  }
};

module.exports = cfg;
