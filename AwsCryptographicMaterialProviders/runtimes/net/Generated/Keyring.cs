// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
// Do not modify this file. This file is machine generated, and any changes to it will be overwritten.
using System;
 using System.IO;
 using System.Collections.Generic;
 using AWS.Cryptography.MaterialProviders;
 using Dafny.Aws.Cryptography.MaterialProviders.Types; namespace AWS.Cryptography.MaterialProviders {
 internal class Keyring : KeyringBase {
 internal readonly Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring _impl;
 internal Keyring(Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring impl) { this._impl = impl; }
 protected override AWS.Cryptography.MaterialProviders.OnEncryptOutput _OnEncrypt(AWS.Cryptography.MaterialProviders.OnEncryptInput input) {
 Dafny.Aws.Cryptography.MaterialProviders.Types._IOnEncryptInput internalInput = TypeConversion.ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnEncryptInput(input);
 Wrappers_Compile._IResult<Dafny.Aws.Cryptography.MaterialProviders.Types._IOnEncryptOutput, Dafny.Aws.Cryptography.MaterialProviders.Types._IError> result = this._impl.OnEncrypt(internalInput);
 if (result.is_Failure) throw TypeConversion.FromDafny_CommonError(result.dtor_error);
 return TypeConversion.FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnEncryptOutput(result.dtor_value);
}
 protected override AWS.Cryptography.MaterialProviders.OnDecryptOutput _OnDecrypt(AWS.Cryptography.MaterialProviders.OnDecryptInput input) {
 Dafny.Aws.Cryptography.MaterialProviders.Types._IOnDecryptInput internalInput = TypeConversion.ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput(input);
 Wrappers_Compile._IResult<Dafny.Aws.Cryptography.MaterialProviders.Types._IOnDecryptOutput, Dafny.Aws.Cryptography.MaterialProviders.Types._IError> result = this._impl.OnDecrypt(internalInput);
 if (result.is_Failure) throw TypeConversion.FromDafny_CommonError(result.dtor_error);
 return TypeConversion.FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnDecryptOutput(result.dtor_value);
}
}
}
