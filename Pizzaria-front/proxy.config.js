const PROXY_CONFIG = [
    {
        context: ['/api'],
        target: 'https://localhost:7248/',
        secure: true,
        logLevel: 'debug',
        pathRewrite: { '^/api': ''}
    }
]