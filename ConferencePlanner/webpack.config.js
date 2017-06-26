'use strict';
var appPath = __dirname;
var webpack = require('webpack');
var HtmlWebpackPlugin = require('html-webpack-plugin');
var ExtractTextPlugin = require('extract-text-webpack-plugin');


module.exports = {
    context: appPath,
    devtool: 'source-map',
    entry: {
        app: [
            './Scripts/startup.js',
            './Styles/app.less'
        ]
    },
    output: {
        path: appPath + '/dist',
        filename: 'webpack_bundle_[name].js?[hash]',
        publicPath: '~/dist'
    },
    module: {
        rules: [{
            test: /\.less$/,
            use: ExtractTextPlugin.extract({
                use: [{
                    loader: "css-loader"
                }, {
                    loader: "less-loader"
                }]
            })
        }]
    },
    plugins: [new HtmlWebpackPlugin({
        template: 'Views/Shared/_Layout_src.cshtml',
        filename: '../Views/Shared/_Layout.cshtml',
        inject: 'head'
    }),
    new ExtractTextPlugin({
        filename: "[name].css?[contenthash]",
        disable: false
    })
    ]
}
