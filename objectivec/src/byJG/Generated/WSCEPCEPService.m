/*
	WSCEPCEPService.m
	The implementation classes and methods for the CEPService web service.
	Generated by SudzC.com
*/

#import "WSCEPCEPService.h"
				
#import "Soap.h"
	
#import "WSCEPArrayOfstring.h"

/* Implementation of the service */
				
@implementation WSCEPCEPService

	- (id) init
	{
		if(self = [super init])
		{
			self.serviceUrl = @"http://www.byjg.com.br/site/webservice.php/ws/cep";
			self.namespace = @"urn:CEPService";
			self.headers = nil;
			self.logging = NO;
		}
		return self;
	}
	
	- (id) initWithUsername: (NSString*) username andPassword: (NSString*) password {
		if(self = [super initWithUsername:username andPassword:password]) {
		}
		return self;
	}
	
	+ (WSCEPCEPService*) service {
		return [WSCEPCEPService serviceWithUsername:nil andPassword:nil];
	}
	
	+ (WSCEPCEPService*) serviceWithUsername: (NSString*) username andPassword: (NSString*) password {
		return [[[WSCEPCEPService alloc] initWithUsername:username andPassword:password] autorelease];
	}

		
	/* Returns NSString*. Retorna a versao do WebService */
	- (SoapRequest*) obterVersao: (id <SoapDelegate>) handler
	{
		return [self obterVersao: handler action: nil];
	}

	- (SoapRequest*) obterVersao: (id) _target action: (SEL) _action
		{
		NSMutableArray* _params = [NSMutableArray array];
		
		NSString* _envelope = [Soap createEnvelope: @"obterVersao" forNamespace: self.namespace withParameters: _params withHeaders: self.headers];
		SoapRequest* _request = [SoapRequest create: _target action: _action service: self soapAction: self.serviceUrl postData: _envelope deserializeTo: @"NSString"];
		[_request send];
		return _request;
	}

	/* Returns NSString*. Retorna o nome do logradouro ? partir do CEP fornecido. Esse m?todo ser? desativado em 30 de Outubro de 2008. */
	- (SoapRequest*) obterLogradouro: (id <SoapDelegate>) handler cep: (NSString*) cep
	{
		return [self obterLogradouro: handler action: nil cep: cep];
	}

	- (SoapRequest*) obterLogradouro: (id) _target action: (SEL) _action cep: (NSString*) cep
		{
		NSMutableArray* _params = [NSMutableArray array];
		
		[_params addObject: [[[SoapParameter alloc] initWithValue: cep forName: @"cep"] autorelease]];
		NSString* _envelope = [Soap createEnvelope: @"obterLogradouro" forNamespace: self.namespace withParameters: _params withHeaders: self.headers];
		SoapRequest* _request = [SoapRequest create: _target action: _action service: self soapAction: self.serviceUrl postData: _envelope deserializeTo: @"NSString"];
		[_request send];
		return _request;
	}

	/* Returns NSString*. Retorna o nome do logradouro ? partir do CEP fornecido. Esse m?todo requer autentica??o do usu?rio. */
	- (SoapRequest*) obterLogradouroAuth: (id <SoapDelegate>) handler cep: (NSString*) cep usuario: (NSString*) usuario senha: (NSString*) senha
	{
		return [self obterLogradouroAuth: handler action: nil cep: cep usuario: usuario senha: senha];
	}

	- (SoapRequest*) obterLogradouroAuth: (id) _target action: (SEL) _action cep: (NSString*) cep usuario: (NSString*) usuario senha: (NSString*) senha
		{
		NSMutableArray* _params = [NSMutableArray array];
		
		[_params addObject: [[[SoapParameter alloc] initWithValue: cep forName: @"cep"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: usuario forName: @"usuario"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: senha forName: @"senha"] autorelease]];
		NSString* _envelope = [Soap createEnvelope: @"obterLogradouroAuth" forNamespace: self.namespace withParameters: _params withHeaders: self.headers];
		SoapRequest* _request = [SoapRequest create: _target action: _action service: self soapAction: self.serviceUrl postData: _envelope deserializeTo: @"NSString"];
		[_request send];
		return _request;
	}

	/* Returns WSCEPArrayOfstring*. Retorna o CEP ? partir do nome do logradouro, localidade e unidade federativa. Aten??o: Somente ser?o retornadas as 5 primeiras linhas. Esse m?todo ser? desativado em 30 de Outubro de 2008. */
	- (SoapRequest*) obterCEP: (id <SoapDelegate>) handler logradouro: (NSString*) logradouro localidade: (NSString*) localidade UF: (NSString*) UF
	{
		return [self obterCEP: handler action: nil logradouro: logradouro localidade: localidade UF: UF];
	}

	- (SoapRequest*) obterCEP: (id) _target action: (SEL) _action logradouro: (NSString*) logradouro localidade: (NSString*) localidade UF: (NSString*) UF
		{
		NSMutableArray* _params = [NSMutableArray array];
		
		[_params addObject: [[[SoapParameter alloc] initWithValue: logradouro forName: @"logradouro"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: localidade forName: @"localidade"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: UF forName: @"UF"] autorelease]];
		NSString* _envelope = [Soap createEnvelope: @"obterCEP" forNamespace: self.namespace withParameters: _params withHeaders: self.headers];
		SoapRequest* _request = [SoapRequest create: _target action: _action service: self soapAction: self.serviceUrl postData: _envelope deserializeTo: [[WSCEPArrayOfstring alloc] autorelease]];
		[_request send];
		return _request;
	}

	/* Returns WSCEPArrayOfstring*. Retorna o CEP ? partir do nome do logradouro, localidade e unidade federativa. Esse m?todo requer autentica??o de usu?rio. Se autenticado, retorna as 20 primeiras linhas encontradas. */
	- (SoapRequest*) obterCEPAuth: (id <SoapDelegate>) handler logradouro: (NSString*) logradouro localidade: (NSString*) localidade UF: (NSString*) UF usuario: (NSString*) usuario senha: (NSString*) senha
	{
		return [self obterCEPAuth: handler action: nil logradouro: logradouro localidade: localidade UF: UF usuario: usuario senha: senha];
	}

	- (SoapRequest*) obterCEPAuth: (id) _target action: (SEL) _action logradouro: (NSString*) logradouro localidade: (NSString*) localidade UF: (NSString*) UF usuario: (NSString*) usuario senha: (NSString*) senha
		{
		NSMutableArray* _params = [NSMutableArray array];
		
		[_params addObject: [[[SoapParameter alloc] initWithValue: logradouro forName: @"logradouro"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: localidade forName: @"localidade"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: UF forName: @"UF"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: usuario forName: @"usuario"] autorelease]];
		[_params addObject: [[[SoapParameter alloc] initWithValue: senha forName: @"senha"] autorelease]];
		NSString* _envelope = [Soap createEnvelope: @"obterCEPAuth" forNamespace: self.namespace withParameters: _params withHeaders: self.headers];
            SoapRequest* _request = [SoapRequest create: _target action: _action service: self soapAction: self.serviceUrl postData: _envelope deserializeTo: @"NSString"]; //[[WSCEPArrayOfstring alloc] autorelease]];
		[_request send];
		return _request;
	}


@end
	